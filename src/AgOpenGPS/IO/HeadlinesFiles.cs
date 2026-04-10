using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace AgOpenGPS.IO
{
    public static class HeadlinesFiles
    {
        public static List<CHeadPath> Load(string fieldDirectory)
        {
            List<CHeadPath> result = new();
            string path = Path.Combine(fieldDirectory, "Headlines.txt");
            if (!File.Exists(path)) return result;

            using (StreamReader reader = new(path))
            {
                reader.ReadLine(); // optional header
                while (!reader.EndOfStream)
                {
                    CHeadPath hp = new()
                    {
                        name = reader.ReadLine() ?? string.Empty
                    };

                    string line = reader.ReadLine(); if (line == null) break;
                    hp.moveDistance = double.Parse(line, CultureInfo.InvariantCulture);

                    line = reader.ReadLine(); if (line == null) break;
                    hp.mode = int.Parse(line, CultureInfo.InvariantCulture);

                    line = reader.ReadLine(); if (line == null) break;
                    hp.a_point = int.Parse(line, CultureInfo.InvariantCulture);

                    line = reader.ReadLine(); if (line == null) break;
                    int numPoints = int.Parse(line, CultureInfo.InvariantCulture);

                    for (int i = 0; i < numPoints && !reader.EndOfStream; i++)
                    {
                        string[] words = (reader.ReadLine() ?? string.Empty).Split(',');
                        if (words.Length < 3) continue;

                        if (double.TryParse(words[0], NumberStyles.Float, CultureInfo.InvariantCulture, out double easting) &&
                            double.TryParse(words[1], NumberStyles.Float, CultureInfo.InvariantCulture, out double northing) &&
                            double.TryParse(words[2], NumberStyles.Float, CultureInfo.InvariantCulture, out double heading))
                        {
                            hp.trackPts.Add(new Vec3(easting, northing, heading));
                        }
                    }

                    if (hp.trackPts.Count > 3) result.Add(hp);
                }
            }

            return result;
        }

        public static void Save(string fieldDirectory, IReadOnlyList<CHeadPath> headPaths)
        {
            string filename = Path.Combine(fieldDirectory, "Headlines.txt");

            using StreamWriter writer = new(filename, false);
            writer.WriteLine("$HeadLines");
            if (headPaths == null || headPaths.Count == 0) return;

            for (int i = 0; i < headPaths.Count; i++)
            {
                CHeadPath hp = headPaths[i];
                writer.WriteLine(hp.name);
                writer.WriteLine(hp.moveDistance.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine(hp.mode.ToString(CultureInfo.InvariantCulture));
                writer.WriteLine(hp.a_point.ToString(CultureInfo.InvariantCulture));

                List<Vec3> pts = hp.trackPts ?? new List<Vec3>();
                writer.WriteLine(pts.Count.ToString(CultureInfo.InvariantCulture));

                for (int j = 0; j < pts.Count; j++)
                {
                    Vec3 p = pts[j];
                    writer.WriteLine($"{FileIoUtils.FormatDouble(p.easting, 3)} , {FileIoUtils.FormatDouble(p.northing, 3)} , {FileIoUtils.FormatDouble(p.heading, 5)}");
                }
            }
        }
    }
}
