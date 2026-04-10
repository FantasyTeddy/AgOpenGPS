namespace AgOpenGPS.Core.Models
{
    public struct GeoBoundingBox
    {
        public static GeoBoundingBox CreateEmpty()
        {
            GeoCoord minCoord = new(double.MaxValue, double.MaxValue);
            GeoCoord maxCoord = new(double.MinValue, double.MinValue);
            return new GeoBoundingBox(minCoord, maxCoord);
        }

        public GeoBoundingBox(GeoCoord minCoord, GeoCoord maxCoord)
        {
            MinCoord = minCoord;
            MaxCoord = maxCoord;
        }

        public bool IsEmpty =>
            MaxCoord.Northing < MinCoord.Northing &&
            MaxCoord.Easting < MinCoord.Easting;
        public double MinNorthing => MinCoord.Northing;
        public double MaxNorthing => MaxCoord.Northing;
        public double MinEasting => MinCoord.Easting;
        public double MaxEasting => MaxCoord.Easting;
        public GeoCoord MinCoord { get; private set; }
        public GeoCoord MaxCoord { get; private set; }
        public GeoCoord CenterCoord => MinCoord.Average(MaxCoord);

        public void Include(GeoCoord geoCoord)
        {
            MinCoord = MinCoord.Min(geoCoord);
            MaxCoord = MaxCoord.Max(geoCoord);
        }

        public void Include(GeoBoundingBox bb)
        {
            MinCoord = MinCoord.Min(bb.MinCoord);
            MaxCoord = MaxCoord.Max(bb.MaxCoord);
        }

        public bool IsInside(GeoCoord testCoord)
        {
            return
                MinCoord.Northing <= testCoord.Northing && testCoord.Northing <= MaxCoord.Northing &&
                MinCoord.Easting <= testCoord.Easting && testCoord.Easting <= MaxCoord.Easting;
        }

    }

}
