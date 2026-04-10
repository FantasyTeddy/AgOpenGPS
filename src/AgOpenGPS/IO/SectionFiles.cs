using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace AgOpenGPS.IO
{
    public static class SectionsFiles
    {
        public sealed class SectionsData
        {
            public List<List<vec3>> Patches { get; } = new List<List<vec3>>();
            public double TotalArea { get; set; }
        }

        public static List<List<vec3>> Load(string fieldDirectory)
        {
            List<List<vec3>> result = new();
            string path = Path.Combine(fieldDirectory, "Sections.txt");
            if (!File.Exists(path)) return result;

            using (StreamReader reader = new(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    if (!int.TryParse(line.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int verts))
                        continue;

                    List<vec3> patch = FileIoUtils.ReadVec3Block(reader, verts);
                    if (patch.Count > 0)
                    {
                        result.Add(patch);
                    }
                }
            }

            return result;
        }

        public static void Append(string fieldDirectory, IEnumerable<IReadOnlyList<vec3>> patches)
        {
            string filename = Path.Combine(fieldDirectory, "Sections.txt");
            if (patches == null) return;

            using StreamWriter writer = new(filename, true);
            foreach (IReadOnlyList<vec3> triList in patches)
            {
                if (triList == null) continue;
                writer.WriteLine(triList.Count.ToString(CultureInfo.InvariantCulture));
                for (int i = 0; i < triList.Count; i++)
                {
                    vec3 p = triList[i];
                    writer.WriteLine($"{FileIoUtils.FormatDouble(p.easting, 3)},{FileIoUtils.FormatDouble(p.northing, 3)},{FileIoUtils.FormatDouble(p.heading, 5)}");
                }
            }
        }

        public static void CreateEmpty(string fieldDirectory)
        {
            using StreamWriter writer = new(Path.Combine(fieldDirectory, "Sections.txt"), false);
            // Intentionally empty
        }
    }
}
