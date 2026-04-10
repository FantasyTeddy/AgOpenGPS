using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace AgOpenGPS.IO
{
    public static class FileIoUtils
    {
        // ---- Formatting helper ----
        public static string FormatDouble(double value, int decimals)
        {
            return Math.Round(value, decimals).ToString(CultureInfo.InvariantCulture);
        }

        // ---- Parsing helpers ----

        public static int ParseIntSafe(string line)
        {
            if (!string.IsNullOrWhiteSpace(line) &&
                int.TryParse(line.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int v))
            {
                return v;
            }
            return 0;
        }

        public static List<vec3> ReadVec3Block(StreamReader r, int count)
        {
            List<vec3> list = new List<vec3>(count > 0 ? count : 0);
            for (int i = 0; i < count && !r.EndOfStream; i++)
            {
                string[] words = (r.ReadLine() ?? string.Empty).Split(',');
                if (words.Length < 3) continue;

                if (double.TryParse(words[0], NumberStyles.Float, CultureInfo.InvariantCulture, out double e) &&
                    double.TryParse(words[1], NumberStyles.Float, CultureInfo.InvariantCulture, out double n) &&
                    double.TryParse(words[2], NumberStyles.Float, CultureInfo.InvariantCulture, out double h))
                {
                    list.Add(new vec3(e, n, h));
                }
            }
            return list;
        }
    }
}
