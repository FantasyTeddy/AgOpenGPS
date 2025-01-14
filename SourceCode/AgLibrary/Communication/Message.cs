using System;
using System.Runtime.Serialization;

namespace AgLibrary.Communication
{
    public class Message
    {
        private Message(byte source, PGN pgn)
        {
            Source = source;
            PGN = pgn;
        }

        public byte Source { get; }
        public PGN PGN { get; }

        public static Message Deserialize(byte[] data)
        {
            if (data.Length < 5)
            {
                throw new SerializationException("Message too short");
            }

            if (data[0] != 0x80 || data[1] != 0x81)
            {
                throw new SerializationException("Preamble invalid");
            }

            byte source = data[2];

            byte pgnValue = data[3];

            byte length = data[4];
            if (length != data.Length - 6)
            {
                throw new SerializationException($"Length of message invalid ({length} != {data.Length} - 6)");
            }

            byte crc = data[data.Length - 1];
            byte calculatedCrc = CalculateCrc(data, 2, data.Length - 2);
            if (crc != calculatedCrc)
            {
                throw new SerializationException($"CRC value ({calculatedCrc}) does not match");
            }

            byte[] pgnData = new byte[length];
            Array.Copy(data, 5, pgnData, 0, length);

            PGN pgn = PGN.Deserialize(pgnValue, pgnData);

            return new Message(source, pgn);
        }

        public byte[] Serialize()
        {
            (byte pgnValue, byte[] pgnData) = PGN.Serialize();

            byte length = (byte)pgnData.Length;

            byte[] data = new byte[length + 6];

            data[0] = 0x80;
            data[1] = 0x81;
            data[2] = Source;
            data[3] = pgnValue;
            data[4] = length;

            Array.Copy(pgnData, 0, data, 5, length);

            byte crc = CalculateCrc(data, 2, data.Length - 2);
            data[data.Length - 1] = crc;

            return data;
        }

        private static byte CalculateCrc(byte[] data, int start, int end)
        {
            byte crc = 0;
            for (int i = start; i <= end; i++)
            {
                crc += data[i];
            }
            return crc;
        }
    }
}
