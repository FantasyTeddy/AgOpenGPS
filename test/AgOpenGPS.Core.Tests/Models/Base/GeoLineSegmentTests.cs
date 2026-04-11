using AgOpenGPS.Core.Models;
using NUnit.Framework;

namespace AgOpenGPS.Core.Tests.Models
{
    public class GeoLineSegmentTests
    {

        [Test]
        public void Test_IntersectionPoint_Intersects()
        {
            // Arrange
            GeoCoord coordA = new(13.0, -10.0);
            GeoCoord coordB = new(12.0, -19.0);
            GeoCoord otherCoordA = new(14.0, -18.0);
            GeoCoord otherCoordB = new(-8, -5);
            GeoLineSegment lineSegment = new(coordA, coordB);
            GeoLineSegment otherLineSegment = new(otherCoordA, otherCoordB);

            // Act
            GeoCoord? interSectionPoint = lineSegment.IntersectionPoint(otherLineSegment);

            // Assert
            Assert.That(interSectionPoint.HasValue, Is.True);
            // Intersection point must lie on first segment
            Assert.That(
                coordA.Distance(interSectionPoint.Value) + interSectionPoint.Value.Distance(coordB),
                Is.EqualTo(coordA.Distance(coordB))
            );
            // Intersection point must lie on other segment too
            Assert.That(
                otherCoordA.Distance(interSectionPoint.Value) + interSectionPoint.Value.Distance(otherCoordB),
                Is.EqualTo(otherCoordA.Distance(otherCoordB))
            );
        }

        [Test]
        public void Test_IntersectionPoint_NoIntersection()
        {
            // Arrange
            GeoCoord coordA = new(13.0, -1);
            GeoCoord coordB = new(18.0, -1);
            GeoCoord otherCoordA = new(-2.0, -18.0);
            GeoCoord otherCoordB = new(-2.0, 100);
            GeoLineSegment northHeadingSegment = new(coordA, coordB);
            GeoLineSegment eastHeadingSegment = new(otherCoordA, otherCoordB);

            // Act
            GeoCoord? interSectionPoint = northHeadingSegment.IntersectionPoint(eastHeadingSegment);

            // Assert
            Assert.That(interSectionPoint.HasValue, Is.False);
        }

        [Test]
        public void Test_IntersectionPoint_SymetricalSegmentsCrossInTheMiddle()
        {
            // Arrange
            const double minNorthing = -1.0;
            const double maxNorthing = 3.0;
            const double minEasting = 2.0;
            const double maxEasting = 4.0;
            GeoCoord neCoord = new(maxNorthing, maxEasting);
            GeoCoord seCoord = new(minNorthing, maxEasting);
            GeoCoord swCoord = new(minNorthing, minEasting);
            GeoCoord nwCoord = new(maxNorthing, minEasting);
            GeoLineSegment nwseLineSegment = new(nwCoord, seCoord);
            GeoLineSegment swneLineSegment = new(swCoord, neCoord);

            // Act
            GeoCoord? interSectionPoint = nwseLineSegment.IntersectionPoint(swneLineSegment);

            // Assert
            Assert.That(interSectionPoint.HasValue, Is.True);
            Assert.That(interSectionPoint.Value.Distance(nwCoord), Is.EqualTo(interSectionPoint.Value.Distance(seCoord)));
        }

        [Test]
        public void Test_IntersectionPoint_ParallelSegmentsDoNotIntersect()
        {
            // Arrange
            const double minNorthing = -1.0;
            const double maxNorthing = 3.0;
            const double minEasting = 2.0;
            const double maxEasting = 4.0;
            GeoCoord seCoord = new(minNorthing, maxEasting);
            GeoCoord nwCoord = new(maxNorthing, minEasting);
            GeoDelta shift = new(1.0, 0.0);
            GeoLineSegment nwseLineSegment = new(nwCoord, seCoord);
            GeoLineSegment shiftedSegment = new(nwCoord + shift, seCoord + shift);

            // Act
            GeoCoord? intersectionPoint = nwseLineSegment.IntersectionPoint(shiftedSegment);

            // Assert
            Assert.That(intersectionPoint, Is.Null);
        }

        [Test]
        public void Test_IntersectionPoint_LongLineSegment()
        {
            // Arrange
            const double minNorthing = -1.0;
            const double maxNorthing = 3.0;
            const double minEasting = 2.0;
            const double maxEasting = 4.0;
            GeoCoord seCoord = new(minNorthing, maxEasting);
            GeoCoord nwCoord = new(maxNorthing, minEasting);

            GeoDelta delta = new(nwCoord, seCoord);
            GeoLineSegment nwseLineSegment = new(nwCoord, nwCoord + (1000.0 * delta));
            GeoCoord almostEnd = nwCoord + (999.0 * delta);
            GeoLineSegment otherSegment = new(
                almostEnd - (1.0 * new GeoDir(delta).PerpendicularLeft),
                almostEnd + (1.0 * new GeoDir(delta).PerpendicularLeft));

            // Act
            GeoCoord? intersectionPoint = nwseLineSegment.IntersectionPoint(otherSegment);

            // Assert
            Assert.That(intersectionPoint.HasValue, Is.True);
            Assert.That(intersectionPoint.Value.Northing, Is.EqualTo(almostEnd.Northing));
            Assert.That(intersectionPoint.Value.Easting, Is.EqualTo(almostEnd.Easting));
        }

        [Test]
        public void Test_IntersectionPoint_SharedEndPoints()
        {
            // Arrange
            GeoCoord coordA = new(16.88, -15.488);
            GeoCoord otherCoordA = new(-13.355, 16.09);
            GeoCoord sharedEndPoint = new(16.99, -13.55);
            GeoLineSegment segment = new(coordA, sharedEndPoint);
            GeoLineSegment otherSegment = new(otherCoordA, sharedEndPoint);
            GeoLineSegment reversedSegment = new(sharedEndPoint, coordA);
            GeoLineSegment reversedOtherSegment = new(sharedEndPoint, otherCoordA);

            // Act
            GeoCoord? intersectionPoint = segment.IntersectionPoint(otherSegment);
            GeoCoord? ipNormalReversed = segment.IntersectionPoint(reversedOtherSegment);
            GeoCoord? ipReversedNormal = reversedSegment.IntersectionPoint(otherSegment);
            GeoCoord? ipReversedReversed = reversedSegment.IntersectionPoint(reversedOtherSegment);

            // Assert
            Assert.That(intersectionPoint.HasValue, Is.True);
            Assert.That(intersectionPoint.Value, Is.EqualTo(sharedEndPoint));

            Assert.That(ipNormalReversed.HasValue, Is.True);
            Assert.That(ipNormalReversed.Value, Is.EqualTo(sharedEndPoint));

            Assert.That(ipReversedNormal.HasValue, Is.True);
            Assert.That(ipReversedNormal.Value, Is.EqualTo(sharedEndPoint));

            Assert.That(ipReversedReversed.HasValue, Is.True);
            Assert.That(ipReversedReversed.Value, Is.EqualTo(sharedEndPoint));
        }
    }
}
