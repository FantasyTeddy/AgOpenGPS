using System;
using System.Runtime.Serialization;
using System.Text;

namespace AgLibrary.Communication
{
    public class PGN_DD : PGN
    {
        private PGN_DD(byte duration, byte color, string text)
        {
            Duration = duration;
            Color = color;
            Text = text;
        }

        public byte Duration { get; }
        public byte Color { get; }
        public string Text { get; }

        public static PGN_DD Deserialize(byte[] data)
        {
            if (data.Length < 3)
            {
                throw new SerializationException("PGN_DD too short");
            }

            byte duration = data[0];
            byte color = data[1];
            string text = Encoding.UTF8.GetString(data, 2, data.Length - 2);

            return new PGN_DD(duration, color, text);
        }

        public new byte[] Serialize()
        {
            int length = Text.Length + 2;

            byte[] data = new byte[length];

            data[0] = Duration;
            data[1] = Color;

            byte[] textData = Encoding.UTF8.GetBytes(Text);
            Array.Copy(textData, 0, data, 2, textData.Length);

            return data;
        }
    }
}