// This file centralizes all coordinate conversion previously handled in CNMEA
// Now uses LocalPlane, Wgs84, GeoCoord, and related structs (C# 7.1 compatible)

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AgLibrary.Logging;
using AgOpenGPS.Core.AgShare;
using AgOpenGPS.Core.AgShare.Models;
using AgOpenGPS.Core.Models;

namespace AgOpenGPS
{
    public class AgShareUploader
    {
        private readonly AgShareClient _client;

        public AgShareUploader(AgShareClient client)
        {
            _client = client;
        }

        // Create a snapshot from the current GPS session to upload
        public static FieldSnapshot CreateSnapshot(FormGPS gps)
        {
            string dir = Path.Combine(RegistrySettings.fieldsDirectory, gps.CurrentFieldDirectory);
            string idPath = Path.Combine(dir, "agshare.txt");

            Guid fieldId;
            if (File.Exists(idPath))
            {
                string raw = File.ReadAllText(idPath).Trim();
                fieldId = Guid.Parse(raw);
            }
            else
            {
                fieldId = Guid.NewGuid();
            }

            List<List<Vec3>> boundaries = new();
            foreach (CBoundaryList b in gps.bnd.bndList)
            {
                boundaries.Add(b.fenceLine.ToList());
            }

            List<CTrk> tracks = gps.trk.gArr.ToList();

            Wgs84 origin = gps.AppModel.LocalPlane.Origin;
            LocalPlane plane = new(origin, new SharedFieldProperties());

            FieldSnapshot snapshot = new()
            {
                FieldName = gps.DisplayFieldName,
                FieldDirectory = dir,
                FieldId = fieldId,
                OriginLat = origin.Latitude,
                OriginLon = origin.Longitude,
                Convergence = 0,
                Boundaries = boundaries,
                Tracks = tracks,
                Converter = plane
            };
            return snapshot;
        }

        // Upload snapshot to AgShare using boundary with holes
        public async Task UploadAsync(FieldSnapshot snapshot)
        {
            try
            {
                // Allow upload even without boundary - boundary is optional
                List<CoordinateDto> outer = new();
                List<List<CoordinateDto>> holes = new();

                if (snapshot.Boundaries != null && snapshot.Boundaries.Count > 0)
                {
                    // Convert first boundary as outer boundary
                    List<Vec3> firstBoundary = snapshot.Boundaries.FirstOrDefault();
                    if (firstBoundary != null)
                    {
                        outer = ConvertBoundary(firstBoundary, snapshot.Converter);
                        outer ??= new List<CoordinateDto>();
                    }

                    // Convert remaining boundaries as holes
                    foreach (List<Vec3> innerBoundary in snapshot.Boundaries.Skip(1))
                    {
                        List<CoordinateDto> hole = ConvertBoundary(innerBoundary, snapshot.Converter);
                        if (hole != null && hole.Count >= 4) holes.Add(hole);
                    }
                }

                List<GuidanceTrackDto> abLines = ConvertGuidanceTracks(snapshot.Tracks, snapshot.Converter);

                bool isPublic = false;
                try
                {
                    AgShareResult<GetFieldDto> downloadResult = await _client.DownloadFieldAsync(snapshot.FieldId);
                    if (downloadResult.IsSuccessful)
                    {
                        GetFieldDto field = downloadResult.Data;
                        isPublic = field.IsPublic;
                    }
                }
                catch (Exception)
                {
                    Log.EventWriter("Failed to check field visibility on AgShare, defaulting to private.");
                }

                PolygonDto boundary = new()
                {
                    Outer = outer,
                    Holes = holes
                };

                UploadFieldDto payload = new()
                {
                    Name = snapshot.FieldName,
                    IsPublic = isPublic,
                    Origin = new CoordinateDto { Latitude = snapshot.OriginLat, Longitude = snapshot.OriginLon },
                    Boundary = boundary,
                    AbLines = abLines
                };

                AgShareResult result = await _client.UploadFieldAsync(snapshot.FieldId, payload);

                if (result.IsSuccessful)
                {
                    string txtPath = Path.Combine(snapshot.FieldDirectory, "agshare.txt");
                    File.WriteAllText(txtPath, snapshot.FieldId.ToString());
                    Log.EventWriter("Field uploaded to AgShare: " + snapshot.FieldName + " (" + snapshot.FieldId + ")");
                }
            }
            catch (Exception ex)
            {
                Log.EventWriter("Error uploading field to AgShare: " + ex.Message);
            }
        }

        // Convert local NE boundary to WGS84
        private static List<CoordinateDto> ConvertBoundary(List<Vec3> localFence, LocalPlane converter)
        {
            List<CoordinateDto> coords = new();
            for (int i = 0; i < localFence.Count; i++)
            {
                GeoCoord geo = new(localFence[i].northing, localFence[i].easting);
                Wgs84 wgs = converter.ConvertGeoCoordToWgs84(geo);
                coords.Add(new CoordinateDto { Latitude = wgs.Latitude, Longitude = wgs.Longitude });
            }

            if (coords.Count > 1)
            {
                CoordinateDto first = coords[0];
                CoordinateDto last = coords[^1];
                if (first.Latitude != last.Latitude || first.Longitude != last.Longitude)
                {
                    coords.Add(first);
                }
            }

            return coords;
        }

        // Convert track lines from local NE to WGS84 format
        private static List<GuidanceTrackDto> ConvertGuidanceTracks(List<CTrk> tracks, LocalPlane converter)
        {
            List<GuidanceTrackDto> result = new();

            foreach (CTrk ab in tracks)
            {
                if (ab.mode == TrackMode.AB)
                {
                    GeoCoord a = new(ab.ptA.northing, ab.ptA.easting);
                    GeoCoord b = new(ab.ptB.northing, ab.ptB.easting);
                    Wgs84 wgsA = converter.ConvertGeoCoordToWgs84(a);
                    Wgs84 wgsB = converter.ConvertGeoCoordToWgs84(b);

                    result.Add(new GuidanceTrackDto
                    {
                        Name = ab.name,
                        Type = "AB",
                        Coords = new List<CoordinateDto>
                        {
                            new() { Latitude = wgsA.Latitude, Longitude = wgsA.Longitude },
                            new() { Latitude = wgsB.Latitude, Longitude = wgsB.Longitude }
                        }
                    });
                }
                else if (ab.mode == TrackMode.Curve && ab.curvePts.Count >= 2)
                {
                    List<CoordinateDto> coords = new();
                    foreach (Vec3 pt in ab.curvePts)
                    {
                        GeoCoord geo = new(pt.northing, pt.easting);
                        Wgs84 wgs = converter.ConvertGeoCoordToWgs84(geo);
                        coords.Add(new CoordinateDto { Latitude = wgs.Latitude, Longitude = wgs.Longitude });
                    }

                    result.Add(new GuidanceTrackDto
                    {
                        Name = ab.name,
                        Type = "Curve",
                        Coords = coords
                    });
                }
            }

            return result;
        }
    }
}
