using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace AgOpenGPS.IO
{
    public static class RecPathFiles
    {
        public static List<CRecPathPt> Load(string fieldDirectory)
        {
            List<CRecPathPt> list = new();
            string path = Path.Combine(fieldDirectory, "RecPath.txt");
            if (!File.Exists(path)) return list;

            using (StreamReader reader = new(path))
            {
                string headerOrCount = reader.ReadLine();
                string cntLine = reader.ReadLine();

                if (cntLine == null && headerOrCount != null && int.TryParse(headerOrCount.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int numPoints))
                {
                    // single-line count
                }
                else
                {
                    if (cntLine == null || !int.TryParse(cntLine.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out numPoints))
                        return list;
                }

                for (int i = 0; i < numPoints && !reader.EndOfStream; i++)
                {
                    string[] words = (reader.ReadLine() ?? string.Empty).Split(',');
                    if (words.Length < 5) continue;

                    CRecPathPt pt = new(
                        double.Parse(words[0], CultureInfo.InvariantCulture), // easting
                        double.Parse(words[1], CultureInfo.InvariantCulture), // northing
                        double.Parse(words[2], CultureInfo.InvariantCulture), // heading
                        double.Parse(words[3], CultureInfo.InvariantCulture), // speed
                        bool.Parse(words[4]));
                    list.Add(pt);
                }
            }

            return list;

        }
        public static void Save(string fieldDirectory, IReadOnlyList<CRecPathPt> recList, string fileName = "RecPath.txt")
        {
            string filename = Path.Combine(fieldDirectory, fileName ?? "RecPath.txt");

            using StreamWriter writer = new(filename, false);
            writer.WriteLine("$RecPath");
            IReadOnlyList<CRecPathPt> list = recList ?? new List<CRecPathPt>();

            writer.WriteLine(list.Count.ToString(CultureInfo.InvariantCulture));
            for (int i = 0; i < list.Count; i++)
            {
                CRecPathPt p = list[i];
                writer.WriteLine($"{FileIoUtils.FormatDouble(p.Easting, 3)},{FileIoUtils.FormatDouble(p.Northing, 3)},{FileIoUtils.FormatDouble(p.Heading, 3)},{FileIoUtils.FormatDouble(p.Speed, 1)},{p.AutoBtnState}");
            }
        }

        /// <summary>
        /// Create or overwrite an empty RecPath.txt with legacy-compatible header.
        /// </summary>
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

            string path = Path.Combine(fieldDirectory, "RecPath.txt");
            using StreamWriter writer = new(path, false, Encoding.UTF8);
            writer.WriteLine("$RecPath");
            writer.WriteLine("0");
        }
    }
}
