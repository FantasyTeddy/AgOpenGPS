using System;

namespace GPS_Out
{
    public class PGN54908
    {
        // data from AGIO
        // 0        0x80
        // 1        0x81
        // 2        0x7C
        // 3        0xD6
        // 4        0x33    array length - 6
        // 5-12     longitude       double
        // 13-20    latitude        double
        // 21-24    headingDual     float
        // 25-28    heading         float
        // 29-32    speed           float
        // 33-36    roll            float
        // 37-40    altitude        float
        // 41-42    satellites      ushort
        // 43       fixQuality
        // 44-45    hdopX100        ushort
        // 46-47    ageX100         ushort
        // 48-49    imuHeading      ushort
        // 50-51    imuRoll         ushort
        // 52-53    imuPitch        ushort
        // 54-55    imuYaw          ushort
        // 56       CRC

        private const byte cByteCount = 57;
        private ushort cAgeX100;
        private ushort cHdopX100;
        private short cImuPitch;
        private short cImuRoll;
        private readonly frmStart mf;
        private DateTime ReceiveTime;

        public PGN54908(frmStart CalledFrom)
        {
            mf = CalledFrom;
        }

        public float Age
        {
            get
            {
                if (Connected())
                {
                    return (float)(cAgeX100 / 100.0);
                }
                else if (Properties.Settings.Default.Simulate)
                {
                    return 1.8F;
                }
                else
                {
                    return 0;
                }
            }
        }

        public float Altitude
        {
            get
            {
                if (Connected())
                {
                    return field;
                }
                else if (Properties.Settings.Default.Simulate)
                {
                    return 732.0F;
                }
                else
                {
                    return 0;
                }
            }

            private set;
        }

        public byte FixQuality
        {
            get
            {
                if (Connected())
                {
                    return field;
                }
                else if (Properties.Settings.Default.Simulate)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }

            private set;
        }

        public float HDOP
        {
            get
            {
                if (Connected())
                {
                    return (float)(cHdopX100 / 100.0);
                }
                else if (Properties.Settings.Default.Simulate)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        public float HeadingDual
        {
            get
            {
                if (Connected())
                {
                    return field;
                }
                else if (Properties.Settings.Default.Simulate)
                {
                    return 1000;
                }
                else
                {
                    return 0;
                }
            }

            private set;
        }

        public float IMUheading
        {
            get
            {
                if (Connected())
                {
                    return field;
                }
                else if (Properties.Settings.Default.Simulate)
                {
                    return 1000;
                }
                else
                {
                    return 0;
                }
            }

            private set;
        }

        public float IMUpitch
        {
            get
            {
                float Result = 0;
                if (Math.Abs(cImuPitch / 10.0) < 30) Result = (float)(cImuPitch / 10.0);
                return Result;
            }
        }

        public float IMUroll
        {
            get
            {
                float Result = 0;
                if (Math.Abs(cImuRoll / 10.0) < 30) Result = (float)(cImuRoll / 10.0);
                return Result;
            }
        }

        public ushort IMUyawRate
        {
            get
            {
                ushort Result = 0;
                if (field < 30) Result = field;
                return Result;
            }

            private set;
        }

        public double Latitude
        {
            get
            {
                if (Connected())
                {
                    return field;
                }
                else
                {
                    return 0;
                }
            }

            private set;
        }

        public double Longitude
        {
            get
            {
                if (Connected())
                {
                    return field;
                }
                else
                {
                    return 0;
                }
            }

            private set;
        }

        public float Roll
        {
            get
            {
                float Result = 0;

                if (Math.Abs(field) < 30)
                {
                    Result = field;
                }
                else if (Math.Abs(cImuRoll / 10.0) < 30)
                {
                    Result = (float)(cImuRoll / 10.0);
                }

                return Result;
            }

            private set;
        }

        public UInt16 Satellites
        {
            get
            {
                if (Connected())
                {
                    return field;
                }
                else if (Properties.Settings.Default.Simulate)
                {
                    return 12;
                }
                else
                {
                    return 0;
                }
            }

            private set;
        }

        public float Speed
        {
            get
            {
                if (Connected())
                {
                    if (field < 100)
                    {
                        return field;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else if (Properties.Settings.Default.Simulate)
                {
                    return 4.8F;
                }
                else
                {
                    return 0;
                }
            }

            private set;
        }

        public float TrueHeading
        {
            get
            {
                if (Connected())
                {
                    return field;
                }
                else if (Properties.Settings.Default.Simulate)
                {
                    return 1000;
                }
                else
                {
                    return 0;
                }
            }

            private set;
        }

        public bool Connected()
        {
            return (DateTime.Now - ReceiveTime).TotalSeconds < 4;
        }

        public bool ParseByteData(byte[] Data)
        {
            bool Result = false;
            if (mf.Tls.GoodCRC(Data, 2))
            {
                Longitude = BitConverter.ToDouble(Data, 5);
                Latitude = BitConverter.ToDouble(Data, 13);
                HeadingDual = BitConverter.ToSingle(Data, 21);
                TrueHeading = BitConverter.ToSingle(Data, 25);
                Speed = BitConverter.ToSingle(Data, 29);
                Roll = BitConverter.ToSingle(Data, 33);
                Altitude = BitConverter.ToSingle(Data, 37);
                Satellites = BitConverter.ToUInt16(Data, 41);
                FixQuality = Data[43];
                cHdopX100 = BitConverter.ToUInt16(Data, 44);
                cAgeX100 = BitConverter.ToUInt16(Data, 46);
                IMUheading = (float)(BitConverter.ToUInt16(Data, 48) / 10.0);
                cImuRoll = BitConverter.ToInt16(Data, 50);
                cImuPitch = BitConverter.ToInt16(Data, 52);
                IMUyawRate = BitConverter.ToUInt16(Data, 54);

                ReceiveTime = DateTime.Now;
                Result = true;
            }
            return Result;
        }
    }
}