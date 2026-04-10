using System;

namespace GPS_Out.PGNs
{
    public class PGN100
    {
        // data from AOG
        // corrected position
        // 0        header Hi       128 0x80
        // 1        header Lo       129 0x81
        // 2        source          127 0x7F
        // 3        AGIO PGN        100 0x64
        // 4        length          16
        // 5-12     longitude       double
        // 13-20    latitude        double
        // 21       CRC

        // corrected position alternate
        // 0        header Hi       128 0x80
        // 1        header Lo       129 0x81
        // 2        source          127 0x7F
        // 3        AGIO PGN        100 0x64
        // 4        length          24
        // 5-12     longitude       double
        // 13-20    latitude        double
        // 21-28    Fix2Fix         double
        // 29       CRC

        private const byte HeaderCount = 5;
        private readonly FrmStart mf;
        private DateTime ReceiveTime;
        private bool ExtendedPGN = false;

        public PGN100(FrmStart CalledFrom)
        {
            mf = CalledFrom;
            Fix2FixHeading = 1000;    // invalid data flag
        }

        public double Fix2FixHeading
        {
            get
            {
                if (Connected() && Properties.Settings.Default.UseRollCorrected && ExtendedPGN)
                {
                    return field;
                }
                else
                {
                    return 1000;
                }
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

        public bool Connected()
        {
            return (DateTime.Now - ReceiveTime).TotalSeconds < 4;
        }

        public void ParseByteData(byte[] Data)
        {
            try
            {
                if ((Data.Length > HeaderCount) && (Data.Length == Data[4] + HeaderCount + 1))
                {
                    ExtendedPGN = Data[4] == 24;
                    if (mf.Tls.GoodCRC(Data, 2))
                    {
                        Longitude = BitConverter.ToDouble(Data, 5);
                        Latitude = BitConverter.ToDouble(Data, 13);
                        if (Data[4] == 24) Fix2FixHeading = BitConverter.ToDouble(Data, 21);  // alternate pgn
                        ReceiveTime = DateTime.Now;
                        //mf.Tls.WriteByteFile(Data, "AOGdata.txt");
                    }
                }
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("PGN100/ParseByteData: " + ex.ToString());
            }
        }
    }
}