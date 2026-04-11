// BoundaryFiles.cs - Load tolerant to duplicate True/False lines and extra whitespace.
// Purpose: Some legacy files wrote the drive-through flag twice; we accept that pattern.
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace AgOpenGPS.IO
{
    public static class BoundaryFiles
    {
        public static List<CBoundaryList> Load(string fieldDirectory)
        {
            List<CBoundaryList> result = new();
            string path = Path.Combine(fieldDirectory, "Boundary.txt");
            if (!File.Exists(path)) return result;

            using StreamReader reader = new(path);
            // Skip optional header
            string line = reader.ReadLine();
            if (line != null && !line.TrimStart().StartsWith("$", StringComparison.OrdinalIgnoreCase))
            {
                // first line was not header -> treat as first data line
                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                reader.DiscardBufferedData();
            }

            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                CBoundaryList b = new();

                // Some legacy wrote "True/False" twice; accept and consume up to two flags.
                for (int pass = 0; pass < 2; pass++)
                {
                    if (bool.TryParse(line.Trim(), out bool flag))
                    {
                        b.isDriveThru = flag;
                        line = reader.ReadLine();
                        if (line == null) break;
                        continue;
                    }
                    break;
                }

                if (line == null) break;
                string countLine = line.Trim();
                if (!int.TryParse(countLine, NumberStyles.Integer, CultureInfo.InvariantCulture, out int count))
                {
                    break; // malformed count -> stop parsing rings
                }

                // Points
                for (int i = 0; i < count; i++)
                {
                    line = reader.ReadLine();
                    if (line == null) break;
                    string[] parts = line.Split(',');
                    if (parts.Length < 3) continue;
                    if (double.TryParse(parts[0], NumberStyles.Float, CultureInfo.InvariantCulture, out double easting) &&
                        double.TryParse(parts[1], NumberStyles.Float, CultureInfo.InvariantCulture, out double northing) &&
                        double.TryParse(parts[2], NumberStyles.Float, CultureInfo.InvariantCulture, out double heading))
                    {
                        b.fenceLine.Add(new Vec3(easting, northing, heading));
                    }
                }

                // Compute area and ear
                b.CalculateFenceArea(result.Count);
                b.fenceLineEar?.Clear();

                double delta = 0;
                for (int i = 0; i < b.fenceLine.Count; i++)
                {
                    if (i == 0)
                    {
                        b.fenceLineEar.Add(new Vec2(b.fenceLine[i].easting, b.fenceLine[i].northing));
                        continue;
                    }
                    delta += b.fenceLine[i - 1].heading - b.fenceLine[i].heading;
                    if (Math.Abs(delta) > 0.005)
                    {
                        b.fenceLineEar.Add(new Vec2(b.fenceLine[i].easting, b.fenceLine[i].northing));
                        delta = 0;
                    }
                }

                result.Add(b);
            }

            return result;
        }

        public static void Save(string fieldDirectory, IReadOnlyList<CBoundaryList> boundaries)
        {
            string filename = Path.Combine(fieldDirectory, "Boundary.txt");

            using StreamWriter writer = new(filename, false);
            writer.WriteLine("$Boundary");
            if (boundaries == null || boundaries.Count == 0) return;

            for (int i = 0; i < boundaries.Count; i++)
            {
                CBoundaryList b = boundaries[i];
                List<Vec3> fence = b.fenceLine ?? new List<Vec3>();

                writer.WriteLine(b.isDriveThru.ToString());
                writer.WriteLine(fence.Count.ToString(CultureInfo.InvariantCulture));

                for (int j = 0; j < fence.Count; j++)
                {
                    Vec3 p = fence[j];
                    writer.WriteLine($"{FileIoUtils.FormatDouble(p.easting, 3)},{FileIoUtils.FormatDouble(p.northing, 3)},{FileIoUtils.FormatDouble(p.heading, 5)}");
                }
            }
        }
        public static void CreateEmpty(string fieldDirectory)
        {
            if (string.IsNullOrEmpty(fieldDirectory))
            {
                throw new ArgumentNullException(nameof(fieldDirectory));
            }

            if (!Directory.Exists(fieldDirectory))
            {
                Directory.CreateDirectory(fieldDirectory);
            }

            string path = Path.Combine(fieldDirectory, "Boundary.txt");
            File.WriteAllText(path, "$Boundary" + Environment.NewLine, Encoding.UTF8);
        }
    }
}
