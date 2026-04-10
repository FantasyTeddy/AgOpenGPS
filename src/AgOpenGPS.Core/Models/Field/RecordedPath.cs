using System.Collections.Generic;

namespace AgOpenGPS.Core.Models
{

    public class RecordedPath : GeoPathBase
    {
        public List<RecordedPoint> PointList = new List<RecordedPoint>();

        public override int Count => PointList.Count;

        public override GeoCoord this[int index] => PointList[index].AsGeoCoord;

        public void Clear()
        {
            PointList.Clear();
        }

        public void Add(RecordedPoint point)
        {
            PointList.Add(point);
        }
    }

}
