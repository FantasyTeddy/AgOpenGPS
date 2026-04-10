using AgOpenGPS.Core.Models;
using System.Collections.Generic;

namespace AgOpenGPS.Helpers
{
    public class GeoRefactorHelper
    {

        public static GeoLineSegment GetLineSegment(List<Vec3> list, int index)
        {
            int nextIndex = (index + 1) % list.Count;
            return new GeoLineSegment(list[index].ToGeoCoord(), list[nextIndex].ToGeoCoord());
        }

        public static GeoPolygon ToGeoPolygon(List<Vec3> list)
        {
            GeoPolygon p = new(list.Count);
            foreach (Vec3 v in list)
            {
                p.Add(v.ToGeoCoord());
            }
            return p;
        }

        public static List<Vec3> ToVec3List(GeoPolygon p)
        {
            List<Vec3> list = new(p.Count);
            for (int v = 0; v < p.Count; v++)
            {
                list.Add(new Vec3());
            }
            return list;
        }

        public static GeoCoord[] ToGeoCoordArray(List<Vec2> list)
        {
            GeoCoord[] array = new GeoCoord[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i].ToGeoCoord();
            }
            return array;
        }

        public static GeoCoord[] ToGeoCoordArray(List<Vec3> list)
        {
            GeoCoord[] array = new GeoCoord[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i].ToGeoCoord();
            }
            return array;
        }
    }
}
