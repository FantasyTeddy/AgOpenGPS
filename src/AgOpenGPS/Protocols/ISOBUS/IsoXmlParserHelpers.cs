using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;
using AgOpenGPS.Core;
using AgOpenGPS.Core.Models;

namespace AgOpenGPS.Protocols.ISOBUS
{
    /// <summary>
    /// This class provides helper methods for parsing ISO XML data related to agricultural fields.
    /// It does all the conversion and extraction of coordinates, boundaries, headlands, and guidance lines.
    /// </summary>
    public static class IsoXmlParserHelpers
    {
        // Extract WGS84 origin from PLN or GGP lines
        public static bool TryExtractOrigin(XmlNodeList fieldParts, out Wgs84 origin)
        {
            double latSum = 0, lonSum = 0;
            int count = 0;

            foreach (XmlNode node in fieldParts)
            {
                if (node.Name == "PLN" && node.Attributes["A"]?.Value == "1")
                {
                    AccumulateCoordinates(node, ref latSum, ref lonSum, ref count);
                }
            }

            if (count == 0)
            {
                foreach (XmlNode node in fieldParts)
                {
                    if (node.Name == "GGP")
                    {
                        XmlNode lsg = node.SelectSingleNode("GPN/LSG");
                        if (lsg != null) AccumulateCoordinates(lsg.ParentNode, ref latSum, ref lonSum, ref count);
                    }
                }
            }

            if (count == 0)
            {
                origin = new Wgs84();
                return false;
            }

            origin = new Wgs84(latSum / count, lonSum / count);
            return true;
        }

        // Parse PLN boundaries into CBoundaryList objects
        public static List<CBoundaryList> ParseBoundaries(XmlNodeList fieldParts, ApplicationModel appModel)
        {
            List<CBoundaryList> boundaries = new();
            bool outerBuilt = false;

            foreach (XmlNode node in fieldParts)
            {
                if (node.Name != "PLN") continue;
                string type = node.Attributes["A"]?.Value;

                if ((type == "1" || type == "9") && !outerBuilt)
                {
                    if (node.SelectSingleNode("LSG[@A='1']") is XmlNode lsg)
                    {
                        boundaries.Add(ParseBoundaryFromLSG(lsg, appModel));
                        outerBuilt = true;
                    }
                }
                else if (type is "3" or "4" or "6")
                {
                    if (node.SelectSingleNode("LSG[@A='1']") is XmlNode lsg)
                    {
                        boundaries.Add(ParseBoundaryFromLSG(lsg, appModel));
                    }
                }
            }

            return boundaries;
        }
        // Parse Headland if available
        public static List<Vec3> ParseHeadland(XmlNodeList fieldParts, ApplicationModel appModel)
        {
            foreach (XmlNode node in fieldParts)
            {
                if (node.Name == "PLN" && node.Attributes["A"]?.Value == "10")
                {
                    if (node.SelectSingleNode("LSG[@A='1']") is XmlNode lsg)
                    {
                        List<Vec3> list = new();
                        foreach (XmlNode pnt in lsg.SelectNodes("PNT"))
                        {
                            if (double.TryParse(pnt.Attributes["C"]?.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out double lat) &&
                                double.TryParse(pnt.Attributes["D"]?.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out double lon))
                            {
                                GeoCoord geo = appModel.LocalPlane.ConvertWgs84ToGeoCoord(new Wgs84(lat, lon));
                                list.Add(new Vec3(geo));
                            }
                        }

                        CurveCABTools.CalculateHeadings(list);
                        return list;
                    }
                }
            }

            return new List<Vec3>();
        }


        // Parse all valid guidance lines
        public static List<CTrk> ParseAllGuidanceLines(XmlNodeList fieldParts, ApplicationModel appModel)
        {
            List<CTrk> tracks = new();

            foreach (XmlNode node in fieldParts)
            {
                if (node.Name == "GGP")
                {
                    CTrk trk = ParseGGPNode(node, appModel);
                    if (trk != null) tracks.Add(trk);
                }
                else if (node.Name == "LSG" && node.Attributes["A"]?.Value == "5")
                {
                    CTrk trk = ParseLSGNode(node, appModel);
                    if (trk != null) tracks.Add(trk);
                }
            }

            return tracks;
        }

        public static CBoundaryList ParseBoundaryFromLSG(XmlNode lsg, ApplicationModel appModel)
        {
            CBoundaryList list = new();

            foreach (XmlNode pnt in lsg.SelectNodes("PNT"))
            {
                if (double.TryParse(pnt.Attributes["C"]?.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out double lat) &&
                    double.TryParse(pnt.Attributes["D"]?.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out double lon))
                {
                    GeoCoord geo = appModel.LocalPlane.ConvertWgs84ToGeoCoord(new Wgs84(lat, lon));
                    list.fenceLine.Add(new Vec3(geo));
                }
            }

            return list;
        }

        // Parse GGP → GPN → LSG line
        private static CTrk ParseGGPNode(XmlNode node, ApplicationModel appModel)
        {
            XmlNode gpn = node.SelectSingleNode("GPN");
            XmlNode lsg = gpn?.SelectSingleNode("LSG[@A='5']");
            if (gpn == null || lsg == null) return null;

            string lineType = gpn.Attributes["C"]?.Value;
            string name = gpn.Attributes["B"]?.Value ?? node.Attributes["B"]?.Value ?? "Unnamed";

            if (lineType == "1") return ParseABLine(lsg, name, appModel);
            else if (lineType == "3") return ParseCurveLine(lsg, name, appModel);

            return null;
        }

        // Parse LSG line directly
        private static CTrk ParseLSGNode(XmlNode lsg, ApplicationModel appModel)
        {
            string name = lsg.Attributes["B"]?.Value ?? "Unnamed";
            int count = lsg.SelectNodes("PNT").Count;

            if (count == 2) return ParseABLine(lsg, name, appModel);
            else if (count > 2) return ParseCurveLine(lsg, name, appModel);

            return null;
        }

        // Parse AB line into CTrk
        private static CTrk ParseABLine(XmlNode lsg, string name, ApplicationModel appModel)
        {
            XmlNodeList points = lsg.SelectNodes("PNT");
            if (points.Count < 2) return null;

            Vec2 ptA = ParseVec2(points[0], appModel);
            Vec2 ptB = ParseVec2(points[1], appModel);

            double heading = Math.Atan2(ptB.easting - ptA.easting, ptB.northing - ptA.northing);
            if (heading < 0) heading += Glm.twoPI;

            return new CTrk
            {
                heading = heading,
                mode = TrackMode.AB,
                ptA = ptA,
                ptB = ptB,
                name = name.Trim()
            };
        }

        // Parse Curve line into CTrk
        private static CTrk ParseCurveLine(XmlNode lsg, string name, ApplicationModel appModel)
        {
            XmlNodeList points = lsg.SelectNodes("PNT");
            if (points == null || points.Count <= 2) return null;

            // Build raw list from ISOXML
            List<Vec3> desList = new();
            foreach (XmlNode pnt in points)
            {
                GeoCoord geo = ParseGeoCoord(pnt, appModel);
                desList.Add(new Vec3(geo));
            }

            // Keep originals if you want ptA/ptB to reflect the original span
            Vec3 originalFirst = desList[0];
            Vec3 originalLast = desList[^1];

            // Extend ends before preprocessing (pure, no ref)
            double extendMeters = 100.0;     // tweak as needed
            bool keepOriginalAB = false;   // true => ptA/ptB = original endpoints
            desList = ExtendEnds(desList, extendMeters);

            // CABCurve-like pipeline (no ref, returns new lists)
            desList = CurveCABTools.Preprocess(desList, 1.6, 0.5);
            if (desList == null || desList.Count < 2) return null;

            double avgHeading = CurveCABTools.ComputeAverageHeading(desList);

            // Decide ptA/ptB (extended vs original)
            Vec2 ptA, ptB;
            if (keepOriginalAB)
            {
                ptA = new Vec2(originalFirst.easting, originalFirst.northing);
                ptB = new Vec2(originalLast.easting, originalLast.northing);
            }
            else
            {
                ptA = new Vec2(desList[0].easting, desList[0].northing);
                ptB = new Vec2(desList[^1].easting, desList[^1].northing);
            }

            // Build track
            CTrk track = new()
            {
                heading = avgHeading,
                mode = TrackMode.Curve,
                ptA = ptA,
                ptB = ptB,
                name = string.IsNullOrWhiteSpace(name) ? "Curve_" + DateTime.Now.ToString("HHmmss") : name
            };

            // Copy processed curve points
            for (int i = 0; i < desList.Count; i++)
                track.curvePts.Add(desList[i]);

            return track;
        }

        // Now we can use some helpers

        private static void AccumulateCoordinates(XmlNode parent, ref double latSum, ref double lonSum, ref int count)
        {
            foreach (XmlNode pnt in parent.SelectNodes(".//PNT"))
            {
                if (double.TryParse(pnt.Attributes["C"]?.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out double lat) &&
                    double.TryParse(pnt.Attributes["D"]?.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out double lon))
                {
                    latSum += lat;
                    lonSum += lon;
                    count++;
                }
            }
        }

        private static Vec2 ParseVec2(XmlNode pnt, ApplicationModel appModel)
        {
            double.TryParse(pnt.Attributes["C"]?.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out double lat);
            double.TryParse(pnt.Attributes["D"]?.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out double lon);
            GeoCoord geo = appModel.LocalPlane.ConvertWgs84ToGeoCoord(new Wgs84(lat, lon));
            return new Vec2(geo);
        }

        private static GeoCoord ParseGeoCoord(XmlNode pnt, ApplicationModel appModel)
        {
            double.TryParse(pnt.Attributes["C"]?.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out double lat);
            double.TryParse(pnt.Attributes["D"]?.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out double lon);
            return appModel.LocalPlane.ConvertWgs84ToGeoCoord(new Wgs84(lat, lon));
        }
        private static List<Vec3> ExtendEnds(List<Vec3> pts, double extendMeters)
        {
            if (pts == null || pts.Count < 2 || extendMeters <= 0) return pts;

            // Work on a copy to keep this pure
            List<Vec3> list = new(pts);

            // Extend before the first point (backwards along first segment)
            Vec3 first = list[0];
            Vec3 second = list[1];
            double dxF = first.easting - second.easting;
            double dyF = first.northing - second.northing;
            double lenF = Math.Sqrt((dxF * dxF) + (dyF * dyF));
            if (lenF > 1e-6)
            {
                dxF /= lenF; dyF /= lenF;
                list.Insert(0, new Vec3(
                    first.easting + (dxF * extendMeters),
                    first.northing + (dyF * extendMeters),
                    0
                ));
            }

            // Extend after the last point (forwards along last segment)
            Vec3 last = list[^1];
            Vec3 beforeLast = list[^2];
            double dxL = last.easting - beforeLast.easting;
            double dyL = last.northing - beforeLast.northing;
            double lenL = Math.Sqrt((dxL * dxL) + (dyL * dyL));
            if (lenL > 1e-6)
            {
                dxL /= lenL; dyL /= lenL;
                list.Add(new Vec3(
                    last.easting + (dxL * extendMeters),
                    last.northing + (dyL * extendMeters),
                    0
                ));
            }

            return list;
        }

    }
}
