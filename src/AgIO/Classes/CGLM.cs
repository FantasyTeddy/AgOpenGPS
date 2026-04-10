using System;

namespace AgIO
{
    public static class Glm
    {
        //Regex file expression
        public const string fileRegex = "(^(PRN|AUX|NUL|CON|COM[1-9]|LPT[1-9]|(\\.+)$)(\\..*)?$)|(([\\x00-\\x1f\\\\?*:\";‌​|/<>])+)|([\\.]+)";

        //Degrees Radians Conversions
        public static double ToDegrees(double radians)
        {
            return radians * 57.295779513082325225835265587528;
        }

        public static double ToRadians(double degrees)
        {
            return degrees * 0.01745329251994329576923690768489;
        }

        //Distance calcs of all kinds
        public static double DistanceLonLat(double lon1, double lat1, double lon2, double lat2)
        {
            const int EarthMeanRadius = 6371;

            double dlon = ToRadians(lon2 - lon1);
            double dlat = ToRadians(lat2 - lat1);

            double a = (Math.Sin(dlat / 2) * Math.Sin(dlat / 2)) + (Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) * (Math.Sin(dlon / 2) * Math.Sin(dlon / 2)));
            double angle = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return angle * EarthMeanRadius;
        }

    }
}