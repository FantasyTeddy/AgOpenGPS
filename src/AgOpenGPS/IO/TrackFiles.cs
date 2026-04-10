using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace AgOpenGPS.IO
{
    public static class TrackFiles
    {
        /// <summary>
        /// Load tracks from TrackLines.txt. Throws on malformed content or missing header.
        /// </summary>
        public static List<CTrk> Load(string fieldDirectory)
        {
            if (string.IsNullOrWhiteSpace(fieldDirectory))
                throw new ArgumentNullException(nameof(fieldDirectory));

            List<CTrk> result = new List<CTrk>();
            string path = Path.Combine(fieldDirectory, "TrackLines.txt");
            if (!File.Exists(path)) return result;

            using StreamReader reader = new StreamReader(path);
            // Require header
            string header = reader.ReadLine();
            if (header == null || !header.TrimStart().StartsWith("$", StringComparison.Ordinal))
                throw new InvalidDataException("TrackLines.txt missing $ header.");

            bool isTwolTrackFile = header.Trim() == "$TwolTracks";

            while (!reader.EndOfStream)
            {
                // --- Name ---
                string name = reader.ReadLine();
                if (name == null) break;
                name = name.Trim();
                if (name.Length == 0) continue;

                // --- Heading
                string headingLine = reader.ReadLine();
                if (headingLine == null) throw new InvalidDataException("Unexpected EOF after track name.");
                double heading = double.Parse(headingLine.Trim(), CultureInfo.InvariantCulture);


                // --- A point (easting,northing) ---
                string aLine = reader.ReadLine();
                if (aLine == null) throw new InvalidDataException("Unexpected EOF reading point A.");
                string[] aParts = aLine.Split(',');
                double aEasting = double.Parse(aParts[0], CultureInfo.InvariantCulture);
                double aNorthing = double.Parse(aParts[1], CultureInfo.InvariantCulture);
                vec2 ptA = new vec2(aEasting, aNorthing);

                // --- B point (easting,northing) ---
                string bLine = reader.ReadLine();
                if (bLine == null) throw new InvalidDataException("Unexpected EOF reading point B.");
                string[] bParts = bLine.Split(',');
                double bEasting = double.Parse(bParts[0], CultureInfo.InvariantCulture);
                double bNorthing = double.Parse(bParts[1], CultureInfo.InvariantCulture);
                vec2 ptB = new vec2(bEasting, bNorthing);

                // --- Nudge ---
                string nudgeLine = reader.ReadLine();
                if (nudgeLine == null) throw new InvalidDataException("Unexpected EOF reading nudge.");
                double nudgeDistance = double.Parse(nudgeLine.Trim(), CultureInfo.InvariantCulture);

                // --- Mode ---
                string modeLine = reader.ReadLine();
                if (modeLine == null) throw new InvalidDataException("Unexpected EOF reading mode.");
                int modeInt = int.Parse(modeLine.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture);
                TrackMode modeEnum = (TrackMode)modeInt;

                // --- Visibility ---
                string visLine = reader.ReadLine();
                if (visLine == null) throw new InvalidDataException("Unexpected EOF reading visibility.");
                bool isVisible = bool.Parse(visLine.Trim());

                // --- Curve count ---
                string countLine = reader.ReadLine();
                if (countLine == null) throw new InvalidDataException("Unexpected EOF reading curve count.");
                int curveCount = int.Parse(countLine.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture);

                // --- Curve points ---
                List<vec3> curvePts = new List<vec3>();
                for (int i = 0; i < curveCount; i++)
                {
                    string line = reader.ReadLine();
                    if (line == null) throw new InvalidDataException("Unexpected EOF in curve points.");
                    string[] parts = line.Split(',');
                    double easting = double.Parse(parts[0], CultureInfo.InvariantCulture);
                    double northing = double.Parse(parts[1], CultureInfo.InvariantCulture);
                    double pointheading = double.Parse(parts[2], CultureInfo.InvariantCulture);
                    curvePts.Add(new vec3(easting, northing, pointheading));
                }

                // --- Twol Track --- Don't read inner outer flag or halfToolWidth
                if (isTwolTrackFile)
                {
                    reader.ReadLine();
                    reader.ReadLine();
                }

                // Build CTrk
                CTrk tr = new CTrk
                {
                    name = name,
                    mode = modeEnum,
                    ptA = ptA,
                    ptB = ptB,
                    nudgeDistance = nudgeDistance,
                    isVisible = isVisible,
                    heading = heading,
                    curvePts = curvePts
                };

                result.Add(tr);

            }

            return result;
        }

        /// <summary>
        /// Save tracks to TrackLines.txt. Overwrites the file.
        /// </summary>
        public static void Save(string fieldDirectory, IReadOnlyList<CTrk> tracks)
        {
            if (string.IsNullOrWhiteSpace(fieldDirectory))
                throw new ArgumentNullException(nameof(fieldDirectory));

            string filename = Path.Combine(fieldDirectory, "TrackLines.txt");

            using StreamWriter writer = new StreamWriter(filename, false);
            writer.WriteLine("$TrackLines");
            if (tracks == null || tracks.Count == 0) return;

            foreach (CTrk track in tracks)
            {
                writer.WriteLine(track.name ?? string.Empty);
                writer.WriteLine(track.heading.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine($"{FileIoUtils.FormatDouble(track.ptA.easting, 3)},{FileIoUtils.FormatDouble(track.ptA.northing, 3)}");
                writer.WriteLine($"{FileIoUtils.FormatDouble(track.ptB.easting, 3)},{FileIoUtils.FormatDouble(track.ptB.northing, 3)}");
                writer.WriteLine(track.nudgeDistance.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine(((int)track.mode).ToString(CultureInfo.InvariantCulture));
                writer.WriteLine(track.isVisible.ToString());

                List<vec3> pts = track.curvePts ?? new List<vec3>();
                writer.WriteLine(pts.Count.ToString(CultureInfo.InvariantCulture));
                for (int j = 0; j < pts.Count; j++)
                {
                    vec3 p = pts[j];
                    writer.WriteLine($"{FileIoUtils.FormatDouble(p.easting, 3)},{FileIoUtils.FormatDouble(p.northing, 3)},{FileIoUtils.FormatDouble(p.heading, 5)}");
                }
            }
        }
    }
}
