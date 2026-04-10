//Please, if you use this, share the improvements

using AgOpenGPS.Core.Models;
using System;

namespace AgOpenGPS
{
    public struct Vec3
    {
        public double easting;
        public double northing;
        public double heading;

        public Vec3(double easting, double northing, double heading)
        {
            this.easting = easting;
            this.northing = northing;
            this.heading = heading;
        }

        public Vec3(Vec3 v)
        {
            easting = v.easting;
            northing = v.northing;
            heading = v.heading;
        }

        public Vec3(GeoCoord geoCoord)
        {
            easting = geoCoord.Easting;
            northing = geoCoord.Northing;
            heading = 0.0;
        }

        public readonly GeoCoord ToGeoCoord()
        {
            return new GeoCoord(northing, easting);
        }
        public readonly Vec2 ToVec2()
        {
            return new Vec2(easting, northing);
        }

    }

    public struct VecFix2Fix
    {
        public double easting; //easting
        public double distance; //distance since last point
        public double northing; //norting
        public int isSet;    //altitude

        public VecFix2Fix(double _easting, double _northing, double _distance, int _isSet)
        {
            this.easting = _easting;
            this.distance = _distance;
            this.northing = _northing;
            this.isSet = _isSet;
        }
    }

    public struct Vec2
    {
        public double easting;
        public double northing;

        public Vec2(double easting, double northing)
        {
            this.easting = easting;
            this.northing = northing;
        }

        public Vec2(Vec2 v)
        {
            easting = v.easting;
            northing = v.northing;
        }

        public Vec2(GeoCoord geoCoord)
        {
            northing = geoCoord.Northing;
            easting = geoCoord.Easting;
        }

        public readonly GeoCoord ToGeoCoord()
        {
            return new GeoCoord(northing, easting);
        }

        public static Vec2 operator -(Vec2 lhs, Vec2 rhs)
        {
            return new Vec2(lhs.easting - rhs.easting, lhs.northing - rhs.northing);
        }

        public readonly double HeadingXZ()
        {
            return Math.Atan2(easting, northing);
        }

        public readonly Vec2 Normalize()
        {
            double length = GetLength();
            if (Math.Abs(length) < 0.000000000001)
            {
                throw new DivideByZeroException("Trying to normalize a vector with length of zero.");
            }

            return new Vec2(easting / length, northing / length);
        }

        public readonly double GetLength()
        {
            return Math.Sqrt((easting * easting) + (northing * northing));
        }

        public readonly double GetLengthSquared()
        {
            return (easting * easting) + (northing * northing);
        }

        public static Vec2 operator *(Vec2 self, double s)
        {
            return new Vec2(self.easting * s, self.northing * s);
        }

        public static Vec2 operator +(Vec2 lhs, Vec2 rhs)
        {
            return new Vec2(lhs.easting + rhs.easting, lhs.northing + rhs.northing);
        }

        public static Vec2 Lerp(Vec2 a, Vec2 b, double t)
        {
            return new Vec2(
                a.easting + ((b.easting - a.easting) * t),
                a.northing + ((b.northing - a.northing) * t)
            );
        }

        public static float Cross(Vec2 a, Vec2 b)
        {
            return (float)((a.easting * b.northing) - (a.northing * b.easting));
        }

        public static double Dot(Vec2 a, Vec2 b)
        {
            return (a.easting * b.easting) + (a.northing * b.northing);
        }

        public static bool IsPointOnSegment(Vec2 a, Vec2 b, Vec2 p)
        {
            double lenSq = (b - a).GetLengthSquared();
            double proj = Dot(p - a, b - a) / lenSq;
            return proj is >= 0 and <= 1;
        }

        public static Vec2 ProjectOnSegment(Vec2 a, Vec2 b, Vec2 p, out double t)
        {
            Vec2 ab = b - a;
            double abLenSq = ab.GetLengthSquared();
            if (abLenSq < 1e-6)
            {
                t = 0;
                return a;
            }

            Vec2 ap = p - a;
            t = Math.Max(0, Math.Min(1, Dot(ap, ab) / abLenSq));
            return a + (ab * t);
        }
    }
}
