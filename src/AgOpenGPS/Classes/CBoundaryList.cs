using AgOpenGPS.Core.Models;
using System.Collections.Generic;

namespace AgOpenGPS
{
    public partial class CBoundaryList
    {
        //list of coordinates of boundary line
        public List<Vec3> fenceLine = new(128);

        public List<Vec2> fenceLineEar = new(128);
        public List<Vec3> hdLine = new(128);
        public List<Vec3> turnLine = new(128);

        //constructor
        public CBoundaryList()
        {
            area = 0;
            isDriveThru = false;
        }

        public GeoLineSegment GetHeadLineSegment(int index)
        {
            int nextIndex = (index + 1) % hdLine.Count;
            return new GeoLineSegment(hdLine[index].ToGeoCoord(), hdLine[nextIndex].ToGeoCoord());
        }

    }
}