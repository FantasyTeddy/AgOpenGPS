using System.Globalization;

namespace GPS_Out
{
    public class PGN_VTG
    {
        // $GPVTG,054.7,T,034.4,M,005.5,N,010.2,K*48
        //*
        //   VTG          Track made good and ground speed
        //   054.7,T True track made good(degrees)
        //   034.4,M Magnetic track made good
        //   005.5,N Ground speed, knots
        //   010.2,K Ground speed, Kilometers per hour
        //   *48          Checksum

        private readonly FrmStart mf;

        public PGN_VTG(FrmStart CalledFrom)
        {
            mf = CalledFrom;
        }

        public string Sentence { get; private set; }

        public string Build()
        {
            Sentence = Properties.Settings.Default.SentenceStart + "VTG";

            Sentence += "," + mf.Heading().ToString("000.0", CultureInfo.InvariantCulture) + ",T";

            Sentence += "," + mf.Heading().ToString("000.0", CultureInfo.InvariantCulture) + ",M";

            double knots = mf.AGIOdata.Speed * 0.5399568;
            Sentence += "," + knots.ToString("000.0", CultureInfo.InvariantCulture) + ",N";

            Sentence += "," + mf.AGIOdata.Speed.ToString("000.0", CultureInfo.InvariantCulture) + ",K";

            Sentence += ",*";
            //cSentence += "*";
            string Hex = mf.CheckSum(Sentence).ToString("X2");
            Sentence += Hex;

            return Sentence;
        }
    }
}