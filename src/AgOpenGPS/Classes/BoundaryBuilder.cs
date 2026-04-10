using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using AgLibrary.Logging;
using AgOpenGPS.Core.Models;

namespace AgOpenGPS.Classes
{
    public class BoundaryBuilder
    {
        #region Constants
        private const double INTERSECTION_TOLERANCE = 0.01;
        private const double INTERSECTION_TOLERANCE_SQ = INTERSECTION_TOLERANCE * INTERSECTION_TOLERANCE;
        private const double MAX_SEGMENT_STEP = 1.5;
        private const double INTERSECTION_SEARCH_RADIUS = 5.0;
        private const double TRIM_SEGMENT_LENGTH = 0.5;
        private const double MIN_POLYGON_POINTS = 3;
        #endregion

        #region Properties
        public List<CTrk> InputTracks { get; private set; } = new List<CTrk>();
        public List<Segment> Segments { get; private set; } = new List<Segment>();
        public List<Vec2> IntersectionPoints { get; private set; } = new List<Vec2>();
        public List<Segment> TrimmedSegments { get; private set; } = new List<Segment>();
        public List<Vec3> FinalBoundary { get; private set; } = new List<Vec3>();
        public CBoundaryList FinalizedBoundary { get; private set; }
        #endregion

        #region Public API
        public void SetTracks(List<CTrk> tracks)
        {
            InputTracks = tracks?.ToList() ?? new List<CTrk>();
            Log.EventWriter("Tracks set successfully");
        }

        public void ExtendAllTracks(double extendMeters)
        {
            List<CTrk> extendedTracks = new();

            foreach (CTrk trk in InputTracks)
            {
                List<GeoCoord> pts = trk.mode == TrackMode.AB
                    ? new List<GeoCoord>
                      {
                  new(trk.ptA.northing, trk.ptA.easting),
                  new(trk.ptB.northing, trk.ptB.easting)
                      }
                    : trk.curvePts
                        .Select(p => new GeoCoord(p.northing, p.easting))
                        .ToList();

                List<GeoCoord> extended = ExtendTrackEndpoints(pts, extendMeters);

                if (trk.mode == TrackMode.AB && extended.Count >= 2)
                {
                    trk.ptA = new Vec2(extended[0].Easting, extended[0].Northing);
                    trk.ptB = new Vec2(extended[^1].Easting,
                                       extended[^1].Northing);
                }
                else if (trk.mode == TrackMode.Curve)
                {
                    trk.curvePts = extended
                        .Select(p => new Vec3(p.Easting, p.Northing, 0))
                        .ToList();
                }

                extendedTracks.Add(trk);
            }

            InputTracks = extendedTracks;
        }


        public List<Vec3> BuildTrimmedBoundary()
        {
            try
            {
                if (InputTracks.Count == 0)
                {
                    Log.EventWriter("No input tracks to process");
                    return new List<Vec3>();
                }

                BuildSegments();
                FindIntersections();

                List<Segment> trimmed = TrimSegmentsToIntersections();
                List<Vec3> polygon = ConvertSegmentsToPolygon(trimmed);

                if (polygon.Count < MIN_POLYGON_POINTS)
                {
                    Log.EventWriter("Insufficient points for valid polygon");
                    return new List<Vec3>();
                }

                FinalizedBoundary = FinalizeBoundaryPolygon(polygon);
                FinalBoundary = FinalizedBoundary?.fenceLine ?? new List<Vec3>();

                Log.EventWriter($"Boundary created with {FinalBoundary.Count} points");
                return FinalBoundary;
            }
            catch (Exception ex)
            {
                Log.EventWriter($"Error building boundary: {ex.Message}");
                return new List<Vec3>();
            }
        }

        public bool SaveToBoundaryFile(string fieldDirectory)
        {
            try
            {
                if (FinalBoundary.Count < MIN_POLYGON_POINTS)
                {
                    Log.EventWriter("No valid boundary to save");
                    return false;
                }

                string path = Path.Combine(RegistrySettings.fieldsDirectory, fieldDirectory, "Boundary.txt");
                File.WriteAllLines(path, GetBoundaryFileLines(FinalizedBoundary));
                Log.EventWriter($"Boundary successfully saved to {path}");
                return true;
            }
            catch (Exception ex)
            {
                Log.EventWriter($"Failed to save boundary: {ex.Message}");
                return false;
            }
        }
        #endregion

        #region Core Processing

        // Adds extra length to both ends of a track polyline (AB or Curve).
        // This helps ensure intersections are found just beyond original endpoints.
        private List<GeoCoord> ExtendTrackEndpoints(List<GeoCoord> pts, double extendMeters)
        {
            if (pts == null || pts.Count < 2) return pts;

            List<GeoCoord> result = new(pts.Count + 2);

            // First segment direction
            GeoCoord a0 = pts[0];
            GeoCoord a1 = pts[1];
            GeoDelta dirstart = new(a1, a0);
            double lengthStart = dirstart.Length;
            if (lengthStart > 1e-6)
            {
                double extend = extendMeters / lengthStart;
                GeoCoord extStart = new(
                    a0.Northing + (dirstart.NorthingDelta * extend),
                    a0.Easting + (dirstart.EastingDelta * extend)
                );
                result.Add(extStart);
            }

            for (int i = 0; i < pts.Count; i++) result.Add(pts[i]);

            GeoCoord b0 = pts[^2];
            GeoCoord b1 = pts[^1];
            GeoDelta dirEnd = new(b0, b1);
            double lengthEnd = dirEnd.Length;
            if (lengthEnd > 1e-6)
            {
                double extend = extendMeters / lengthEnd;
                GeoCoord extEnd = new(
                    b1.Northing + (dirEnd.NorthingDelta * extend),
                    b1.Easting + (dirEnd.EastingDelta * extend)
                );
                result.Add(extEnd);
            }

            return result;
        }


        public void BuildSegments()
        {
            try
            {
                Segments = new List<Segment>();
                int totalSegments = 0;

                foreach (CTrk trk in InputTracks)
                {
                    List<Vec2> points = GetTrackPoints(trk);
                    if (points.Count < 2) continue;

                    for (int i = 0; i < points.Count - 1; i++)
                    {
                        Segments.Add(new Segment(points[i], points[i + 1], trk));
                        totalSegments++;
                    }
                }

                Log.EventWriter($"Built {totalSegments} segments from {InputTracks.Count} tracks");
            }
            catch (Exception ex)
            {
                Log.EventWriter($"Error building segments: {ex.Message}");
                Segments = new List<Segment>();
            }
        }

        public void FindIntersections()
        {
            try
            {
                HashSet<Vec2> uniqueIntersections = new(new Vec2EqualityComparer());
                int totalChecks = 0;
                int potentialIntersections = 0;

                for (int i = 0; i < Segments.Count; i++)
                {
                    Segment seg1 = Segments[i];

                    for (int j = i + 1; j < Segments.Count; j++)
                    {
                        Segment seg2 = Segments[j];
                        totalChecks++;

                        // Early exit conditions
                        if (seg1.ParentTrack == seg2.ParentTrack)
                            continue;

                        if (!BoundingBoxesIntersect(seg1, seg2, INTERSECTION_SEARCH_RADIUS))
                            continue;

                        potentialIntersections++;
                        (bool intersects, Vec2 intersection) = LineSegmentsIntersect(seg1.Start, seg1.End, seg2.Start, seg2.End);

                        if (intersects)
                        {
                            seg1.AddIntersection(intersection);
                            seg2.AddIntersection(intersection);
                            uniqueIntersections.Add(intersection);
                        }
                    }
                }

                IntersectionPoints = uniqueIntersections.ToList();
            }
            catch (Exception ex)
            {
                Log.EventWriter($"FindIntersections error: {ex.Message}");
            }
        }

        public List<Segment> TrimSegmentsToIntersections()
        {
            List<Segment> trimmed = new();

            try
            {
                foreach (CTrk trk in InputTracks)
                {
                    List<Segment> trackSegments = Segments.Where(s => s.ParentTrack == trk).ToList();
                    if (trackSegments.Count == 0) continue;

                    List<Vec2> intersections = trackSegments
                        .SelectMany(s => s.Intersections)
                        .Distinct(new Vec2EqualityComparer())
                        .ToList();

                    if (intersections.Count < 2) continue;

                    List<Vec2> originalPoints = GetTrackPoints(trk);
                    if (originalPoints.Count < 2) continue;

                    (double startDist, double endDist) = GetTrimDistances(originalPoints, intersections);
                    if (startDist >= endDist) continue;

                    List<Vec2> trimmedPoints = ExtractTrimmedPoints(originalPoints, startDist, endDist);
                    trimmed.AddRange(CreateUniformSegments(trimmedPoints, trk, TRIM_SEGMENT_LENGTH));
                }

                TrimmedSegments = trimmed;
                Log.EventWriter($"Trimmed {trimmed.Count} segments");
            }
            catch (Exception ex)
            {
                Log.EventWriter($"Error trimming segments: {ex.Message}");
                trimmed = new List<Segment>();
            }

            return trimmed;
        }
        #endregion



        #region Geometry Helpers
        private bool BoundingBoxesIntersect(Segment s1, Segment s2, double tolerance)
        {
            double minX1 = Math.Min(s1.Start.easting, s1.End.easting) - tolerance;
            double maxX1 = Math.Max(s1.Start.easting, s1.End.easting) + tolerance;
            double minY1 = Math.Min(s1.Start.northing, s1.End.northing) - tolerance;
            double maxY1 = Math.Max(s1.Start.northing, s1.End.northing) + tolerance;

            double minX2 = Math.Min(s2.Start.easting, s2.End.easting);
            double maxX2 = Math.Max(s2.Start.easting, s2.End.easting);
            double minY2 = Math.Min(s2.Start.northing, s2.End.northing);
            double maxY2 = Math.Max(s2.Start.northing, s2.End.northing);

            return !(maxX1 < minX2 || maxX2 < minX1 || maxY1 < minY2 || maxY2 < minY1);
        }
        private (bool intersects, Vec2 intersection) LineSegmentsIntersect(Vec2 p1, Vec2 p2, Vec2 p3, Vec2 p4)
        {
            Vec2 r = p2 - p1;
            Vec2 s = p4 - p3;
            Vec2 pq = p3 - p1;

            float rxs = Vec2.Cross(r, s);
            float pqxr = Vec2.Cross(pq, r);

            // Handle parallel/collinear cases first
            if (Math.Abs(rxs) < float.Epsilon)
            {
                // Collinear when pqxr is also near zero
                if (Math.Abs(pqxr) < float.Epsilon)
                {
                    // Collinear - check segment overlap
                    float t0 = (float)(Vec2.Dot(pq, r) / Vec2.Dot(r, r));
                    float t1 = t0 + (float)(Vec2.Dot(s, r) / Vec2.Dot(r, r));
                    if (t0 > t1) (t0, t1) = (t1, t0);

                    if (t0 <= 1 && t1 >= 0)
                    {
                        float intersectionT = Math.Max(0, Math.Min(t0, 1));
                        return (true, p1 + (r * intersectionT));
                    }
                }
                return (false, default); // Parallel but not collinear
            }

            float t = Vec2.Cross(pq, s) / rxs;
            float u = pqxr / rxs;

            if (t >= 0 && t <= 1 && u >= 0 && u <= 1)
            {
                return (true, p1 + (r * t));
            }

            return (false, default);
        }
        #endregion

        #region Boundary Construction
        private List<Vec3> ConvertSegmentsToPolygon(List<Segment> segments)
        {
            if (segments.Count == 0)
                return new List<Vec3>();

            List<Vec3> polygon = new();
            HashSet<Segment> visited = new();
            Segment current = segments[0];

            polygon.Add(current.Start.ToVec3());
            polygon.Add(current.End.ToVec3());
            visited.Add(current);

            while (visited.Count < segments.Count)
            {
                Segment next = FindConnectedSegment(segments, visited, current.End);
                if (next == null) break;

                polygon.Add(next.End.ToVec3());
                visited.Add(next);
                current = next;
            }

            return polygon;
        }

        private CBoundaryList FinalizeBoundaryPolygon(List<Vec3> polygon)
        {
            if (polygon?.Count < MIN_POLYGON_POINTS)
                return null;

            CBoundaryList boundary = new();
            boundary.fenceLine.AddRange(polygon);

            boundary.CalculateFenceArea(0);
            boundary.FixFenceLine(0);

            return boundary;
        }
        #endregion

        #region Helper Methods
        private List<Vec2> GetTrackPoints(CTrk track)
        {
            List<Vec2> points = track.mode == TrackMode.AB
                ? new List<Vec2> { track.ptA, track.ptB }
                : track.curvePts.Select(p => new Vec2(p.easting, p.northing)).ToList();

            return EnforceMaxStep(points, MAX_SEGMENT_STEP);
        }

        private List<Vec2> EnforceMaxStep(List<Vec2> points, double maxStep)
        {
            List<Vec2> result = new();
            if (points.Count == 0) return result;

            result.Add(points[0]);

            for (int i = 1; i < points.Count; i++)
            {
                Vec2 prev = points[i - 1];
                Vec2 current = points[i];
                double distance = (current - prev).GetLength();

                if (distance <= maxStep)
                {
                    result.Add(current);
                    continue;
                }

                // Insert interpolated points
                int steps = (int)Math.Ceiling(distance / maxStep);
                for (int s = 1; s < steps; s++)
                {
                    double t = (double)s / steps;
                    result.Add(Vec2.Lerp(prev, current, t));
                }

                result.Add(current);
            }

            return result;
        }

        private (double startDist, double endDist) GetTrimDistances(List<Vec2> points, List<Vec2> intersections)
        {
            // Calculate cumulative distances along track
            List<double> distances = new() { 0 };
            for (int i = 1; i < points.Count; i++)
            {
                distances.Add(distances[i - 1] + Glm.Distance(points[i - 1], points[i]));
            }

            // Project intersections to get their distances along track
            List<double> intersectionDistances = new();
            foreach (Vec2 pt in intersections)
            {
                for (int i = 0; i < points.Count - 1; i++)
                {
                    if (Vec2.IsPointOnSegment(points[i], points[i + 1], pt))
                    {
                        Vec2.ProjectOnSegment(points[i], points[i + 1], pt, out double _);
                        intersectionDistances.Add(distances[i] + Glm.Distance(points[i], pt));
                        break;
                    }
                }
            }

            return (intersectionDistances.Min(), intersectionDistances.Max());
        }

        private List<Vec2> ExtractTrimmedPoints(List<Vec2> points, double startDist, double endDist)
        {
            List<Vec2> trimmed = new();
            double accumulatedDist = 0;

            for (int i = 0; i < points.Count - 1; i++)
            {
                Vec2 a = points[i];
                Vec2 b = points[i + 1];
                double segmentLength = Glm.Distance(a, b);
                double segmentStart = accumulatedDist;
                double segmentEnd = accumulatedDist + segmentLength;

                // Skip segments completely outside trim range
                if (segmentEnd < startDist || segmentStart > endDist)
                {
                    accumulatedDist = segmentEnd;
                    continue;
                }

                // Calculate trim points on this segment
                double t1 = Math.Max(0, (startDist - segmentStart) / segmentLength);
                double t2 = Math.Min(1, (endDist - segmentStart) / segmentLength);

                Vec2 p1 = Vec2.Lerp(a, b, t1);
                Vec2 p2 = Vec2.Lerp(a, b, t2);

                if (!trimmed.Any() || Glm.Distance(trimmed.Last(), p1) > INTERSECTION_TOLERANCE)
                {
                    trimmed.Add(p1);
                }

                if (Glm.Distance(p1, p2) > INTERSECTION_TOLERANCE)
                {
                    trimmed.Add(p2);
                }

                accumulatedDist = segmentEnd;
            }

            return trimmed;
        }

        private List<Segment> CreateUniformSegments(List<Vec2> points, CTrk parentTrack, double segmentLength)
        {
            List<Segment> segments = new();

            for (int i = 0; i < points.Count - 1; i++)
            {
                Vec2 start = points[i];
                Vec2 end = points[i + 1];
                double distance = Glm.Distance(start, end);
                int steps = Math.Max(1, (int)(distance / segmentLength));

                for (int j = 0; j < steps; j++)
                {
                    double t1 = (double)j / steps;
                    double t2 = (double)(j + 1) / steps;

                    segments.Add(new Segment(
                        Vec2.Lerp(start, end, t1),
                        Vec2.Lerp(start, end, t2),
                        parentTrack));
                }
            }

            return segments;
        }

        private Segment FindConnectedSegment(List<Segment> segments, HashSet<Segment> visited, Vec2 connectionPoint)
        {
            foreach (Segment seg in segments)
            {
                if (visited.Contains(seg)) continue;

                if (Glm.Distance(seg.Start, connectionPoint) < INTERSECTION_TOLERANCE)
                {
                    return seg;
                }

                if (Glm.Distance(seg.End, connectionPoint) < INTERSECTION_TOLERANCE)
                {
                    seg.Reverse();
                    return seg;
                }
            }
            return null;
        }

        private IEnumerable<string> GetBoundaryFileLines(CBoundaryList bnd)
        {
            yield return "$Boundary";
            yield return bnd.isDriveThru.ToString();
            yield return bnd.fenceLine.Count.ToString();

            foreach (Vec3 pt in bnd.fenceLine)
            {
                yield return FormattableString.Invariant(
                    $"{pt.easting:F6},{pt.northing:F6},{pt.heading:F6}");
            }
        }

        #endregion

        #region Static Helpers

        #endregion

        #region Helper Classes
        public class Segment
        {
            public Vec2 Start { get; private set; }
            public Vec2 End { get; private set; }
            public CTrk ParentTrack { get; }
            public List<Vec2> Intersections { get; } = new List<Vec2>();

            public Segment(Vec2 start, Vec2 end, CTrk parentTrack)
            {
                Start = start;
                End = end;
                ParentTrack = parentTrack;
            }

            public void Reverse()
            {
                (Start, End) = (End, Start);
            }

            public void AddIntersection(Vec2 point)
            {
                if (!Intersections.Any(p => (p - point).GetLengthSquared() < INTERSECTION_TOLERANCE_SQ))
                {
                    Intersections.Add(point);
                }
            }
        }

        private class Vec2EqualityComparer : IEqualityComparer<Vec2>
        {
            public bool Equals(Vec2 a, Vec2 b)
            {
                return (a - b).GetLengthSquared() < INTERSECTION_TOLERANCE_SQ;
            }

            public int GetHashCode(Vec2 p)
            {
                return HashCode.Combine(
                    Math.Round(p.easting / INTERSECTION_TOLERANCE),
                    Math.Round(p.northing / INTERSECTION_TOLERANCE)
                );
            }
        }
        #endregion
    }

    public static class Vec2Extensions
    {
        public static Vec3 ToVec3(this Vec2 vector, double heading = 0)
        {
            return new Vec3(vector.easting, vector.northing, heading);
        }
    }
}