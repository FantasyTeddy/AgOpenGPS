using AgOpenGPS.Core.Models;
using System.Collections.Generic;

namespace AgOpenGPS
{
    public class CHeadLine
    {
        public List<CHeadPath> tracksArr = new();

        public int idx;

        public List<Vec3> desList = new();

        public CHeadLine()
        {
        }

    }

    public class CHeadPath
    {
        public List<Vec3> trackPts = new();
        public string name = "";
        public double moveDistance = 0;
        public int mode = 0;
        public int a_point = 0;

        public GeoLineSegment GetHeadPathSegment(int index)
        {
            int nextIndex = (index + 1) % trackPts.Count;
            return new GeoLineSegment(trackPts[index].ToGeoCoord(), trackPts[nextIndex].ToGeoCoord());
        }
    }
}