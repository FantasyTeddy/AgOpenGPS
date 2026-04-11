using System;
using System.Globalization;

namespace GPS_Out
{
    public class PGN_GGA
    {
        //$GPGGA,123519,4807.038,N,01131.000,E,1,08,0.9,545.4,M,46.9,M ,  ,*47
        //   0     1      2      3    4      5 6  7  8   9    10 11  12 13  14
        //        Time Lat       Lon FixSatsOP Alt
        //Where:
        //GGA Global Positioning System Fix Data
        // 123519       Fix taken at 12:35:19 UTC
        // 4807.038,N Latitude 48 deg 07.038' N
        // 01131.000,E Longitude 11 deg 31.000' E
        // 1            Fix quality: 0 = invalid
        //                           1 = GPS fix(SPS)
        //                           2 = DGPS fix
        //                           3 = PPS fix
        //                           4 = Real Time Kinematic
        //                           5 = Float RTK
        //                           6 = estimated(dead reckoning) (2.3 feature)
        //                           7 = Manual input mode
        //                           8 = Simulation mode
        // 08           Number of satellites being tracked
        // 0.9          Horizontal dilution of position
        // 545.4, M      Altitude, Meters, above mean sea level
        // 46.9, M       Height of geoid(mean sea level) above WGS84
        //                  ellipsoid
        // (empty field) time in seconds since last DGPS update
        // (empty field) DGPS station ID number
        // *47          the checksum data, always begins with*

        private readonly FrmStart mf;

        public PGN_GGA(FrmStart CalledFrom)
        {
            mf = CalledFrom;
        }

        public string Sentence { get; private set; }

        public string Build()
        {
            double lat;
            double lon;
            if (mf.AOGdata.Connected() && Properties.Settings.Default.UseRollCorrected)
            {
                lat = mf.AOGdata.Latitude;
                lon = mf.AOGdata.Longitude;
            }
            else
            {
                lat = mf.AGIOdata.Latitude;
                lon = mf.AGIOdata.Longitude;
            }

            Sentence = Properties.Settings.Default.SentenceStart + "GGA";
            Sentence += "," + DateTime.UtcNow.ToString("HHmmss.ff", CultureInfo.InvariantCulture);

            string NS = ",N";
            if (lat < 0) NS = ",S";
            lat = Math.Abs(lat);
            Sentence += "," + ((int)lat).ToString("D2");
            double Mins = (double)(lat - (int)lat) * 60.0;
            Sentence += Mins.ToString(Properties.Settings.Default.SentencePrecisionFormat, CultureInfo.InvariantCulture);
            Sentence += NS;

            string EW = ",E";
            if (lon < 0) EW = ",W";
            lon = Math.Abs(lon);
            Sentence += "," + ((int)lon).ToString("D3");
            Mins = (double)(lon - (int)lon) * 60.0;
            Sentence += Mins.ToString(Properties.Settings.Default.SentencePrecisionFormat, CultureInfo.InvariantCulture);
            Sentence += EW;

            Sentence += "," + mf.AGIOdata.FixQuality.ToString();

            Sentence += "," + mf.AGIOdata.Satellites.ToString("00");

            Sentence += "," + mf.AGIOdata.HDOP.ToString("N2", CultureInfo.InvariantCulture);

            Sentence += "," + mf.AGIOdata.Altitude.ToString("N3", CultureInfo.InvariantCulture) + ",M";

            Sentence += ",0.0,M";

            Sentence += "," + mf.AGIOdata.Age.ToString("N1", CultureInfo.InvariantCulture) + ",";

            Sentence += "0000*";
            string Hex = mf.CheckSum(Sentence).ToString("X2");
            Sentence += Hex;

            return Sentence;
        }
    }
}