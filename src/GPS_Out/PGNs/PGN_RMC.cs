using System;
using System.Globalization;

namespace GPS_Out
{
    public class PGN_RMC
    {
        #region RMC Message

        //$GPRMC,123519,A,4807.038,N,01131.000,E,022.4,084.4,230394,003.1,W*6A

        //RMC          Recommended Minimum sentence C
        //123519       Fix taken at 12:35:19 UTC
        //A            Status A=active or V=Void.
        //4807.038,N   Latitude 48 deg 07.038' N
        //01131.000,E  Longitude 11 deg 31.000' E
        //022.4        Speed over the ground in knots
        //084.4        Track angle in degrees True
        //230394       Date - 23rd of March 1994
        //003.1,W      Magnetic Variation
        //*6A          * Checksum

        #endregion RMC Message

        private frmStart mf;

        public PGN_RMC(frmStart CalledFrom)
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

            Sentence = Properties.Settings.Default.SentenceStart + "RMC";
            Sentence += "," + DateTime.UtcNow.ToString("HHmmss.ff", CultureInfo.InvariantCulture);

            Sentence += ",A";

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

            double knots = mf.AGIOdata.Speed * 0.5399568;
            Sentence += "," + knots.ToString("000.0", CultureInfo.InvariantCulture);

            Sentence += "," + mf.Heading().ToString("000.0", CultureInfo.InvariantCulture);

            Sentence += "," + DateTime.UtcNow.ToString("ddMMyy");

            Sentence += ",0.0,W";

            Sentence += ",*";
            //cSentence += "*";
            string Hex = mf.CheckSum(Sentence).ToString("X2");
            Sentence += Hex;

            return Sentence;
        }
    }
}