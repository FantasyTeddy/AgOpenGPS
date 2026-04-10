using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace AgOpenGPS.IO
{
    public static class HeadlandFiles
    {
        public static void AttachLoad(string fieldDirectory, List<CBoundaryList> boundaries)
        {
            if (boundaries == null || boundaries.Count == 0) return;

            string path = Path.Combine(fieldDirectory, "Headland.txt");
            if (!File.Exists(path)) return;

            using StreamReader reader = new StreamReader(path);
            // Skip optional header
            string line = reader.ReadLine();
            if (line != null && line.Trim().StartsWith("$"))
            {
                line = null;
            }

            for (int k = 0; k < boundaries.Count; k++)
            {
                // if we don't already have a line, read next
                if (line == null) line = reader.ReadLine();
                if (line == null) break;

                if (!int.TryParse(line.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int count))
                    break;

                List<vec3> hd = boundaries[k].hdLine;
                hd?.Clear();

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
                        boundaries[k].hdLine.Add(new vec3(easting, northing, heading));
                    }
                }

                // prepare for next boundary
                line = null;
            }
        }

        public static void Save(string fieldDirectory, IReadOnlyList<CBoundaryList> boundaries)
        {
            string filename = Path.Combine(fieldDirectory, "Headland.txt");

            using StreamWriter writer = new StreamWriter(filename, false);
            writer.WriteLine("$Headland");

            if (boundaries == null || boundaries.Count == 0) return;
            if (boundaries[0].hdLine == null || boundaries[0].hdLine.Count == 0) return;

            for (int i = 0; i < boundaries.Count; i++)
            {
                List<vec3> hd = boundaries[i].hdLine ?? new List<vec3>();
                writer.WriteLine(hd.Count.ToString(CultureInfo.InvariantCulture));

                for (int j = 0; j < hd.Count; j++)
                {
                    vec3 p = hd[j];
                    writer.WriteLine($"{FileIoUtils.FormatDouble(p.easting, 3)},{FileIoUtils.FormatDouble(p.northing, 3)},{FileIoUtils.FormatDouble(p.heading, 5)}");
                }
            }
        }
    }
}
