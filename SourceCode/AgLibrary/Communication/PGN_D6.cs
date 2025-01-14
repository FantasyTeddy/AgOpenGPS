using System;
using System.Runtime.Serialization;

namespace AgLibrary.Communication
{
    public class PGN_D6 : PGN
    {
        private PGN_D6(double longitude, double latitude, float headingTrueDual, float headingTrue,
            float speed, float roll, float altitude, ushort satellitesTracked, byte fixQuality,
            ushort hdopX100, ushort ageX100, ushort imuHeading, short imuRoll, short imuPitch, short imuYawRate)
        {
            Longitude = longitude;
            Latitude = latitude;
            HeadingTrueDual = headingTrueDual;
            HeadingTrue = headingTrue;
            Speed = speed;
            Roll = roll;
            Altitude = altitude;
            SatellitesTracked = satellitesTracked;
            FixQuality = fixQuality;
            HdopX100 = hdopX100;
            AgeX100 = ageX100;
            ImuHeading = imuHeading;
            ImuRoll = imuRoll;
            ImuPitch = imuPitch;
            ImuYawRate = imuYawRate;
        }

        public double Longitude { get; }
        public double Latitude { get; }
        public float HeadingTrueDual { get; }
        public float HeadingTrue { get; }
        public float Speed { get; }
        public float Roll { get; }
        public float Altitude { get; }
        public ushort SatellitesTracked { get; }
        public byte FixQuality { get; }
        public ushort HdopX100 { get; }
        public ushort AgeX100 { get; }
        public ushort ImuHeading { get; }
        public short ImuRoll { get; }
        public short ImuPitch { get; }
        public short ImuYawRate { get; }

        public static PGN_D6 Deserialize(byte[] data)
        {
            if (data.Length != 51)
            {
                throw new SerializationException("PGN_D6 invalid length");
            }

            double longitude = BitConverter.ToDouble(data, 0);
            double latitude = BitConverter.ToDouble(data, 8);
            float headingTrueDual = BitConverter.ToSingle(data, 16);
            float headingTrue = BitConverter.ToSingle(data, 20);
            float speed = BitConverter.ToSingle(data, 24);
            float roll = BitConverter.ToSingle(data, 28);
            float altitude = BitConverter.ToSingle(data, 32);
            ushort satellitesTracked = BitConverter.ToUInt16(data, 36);
            byte fixQuality = data[38];
            ushort hdopX100 = BitConverter.ToUInt16(data, 39);
            ushort ageX100 = BitConverter.ToUInt16(data, 41);
            ushort imuHeading = BitConverter.ToUInt16(data, 43);
            short imuRoll = BitConverter.ToInt16(data, 45);
            short imuPitch = BitConverter.ToInt16(data, 47);
            short imuYawRate = BitConverter.ToInt16(data, 49);

            return new PGN_D6(longitude, latitude, headingTrueDual, headingTrue,
                speed, roll, altitude, satellitesTracked, fixQuality,
                hdopX100, ageX100, imuHeading, imuRoll, imuPitch, imuYawRate);
        }

        public new byte[] Serialize()
        {
            byte[] data = new byte[51];

            Array.Copy(BitConverter.GetBytes(Longitude), 0, data, 0, 8);
            Array.Copy(BitConverter.GetBytes(Latitude), 0, data, 8, 8);
            Array.Copy(BitConverter.GetBytes(HeadingTrueDual), 0, data, 16, 4);
            Array.Copy(BitConverter.GetBytes(HeadingTrue), 0, data, 20, 4);
            Array.Copy(BitConverter.GetBytes(Speed), 0, data, 24, 4);
            Array.Copy(BitConverter.GetBytes(Roll), 0, data, 28, 4);
            Array.Copy(BitConverter.GetBytes(Altitude), 0, data, 32, 4);
            Array.Copy(BitConverter.GetBytes(SatellitesTracked), 0, data, 36, 2);
            data[38] = FixQuality;
            Array.Copy(BitConverter.GetBytes(HdopX100), 0, data, 39, 2);
            Array.Copy(BitConverter.GetBytes(AgeX100), 0, data, 41, 2);
            Array.Copy(BitConverter.GetBytes(ImuHeading), 0, data, 43, 2);
            Array.Copy(BitConverter.GetBytes(ImuRoll), 0, data, 45, 2);
            Array.Copy(BitConverter.GetBytes(ImuPitch), 0, data, 47, 2);
            Array.Copy(BitConverter.GetBytes(ImuYawRate), 0, data, 49, 2);

            return data;
        }
    }
}
