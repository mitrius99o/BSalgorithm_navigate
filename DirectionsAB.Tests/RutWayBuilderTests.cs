using NUnit.Framework;
using DirectionsAB;
using static DirectionsAB.PointCommunications;
using System.Collections.Generic;

namespace DirectionsAB.Tests
{
    public class RutWayBuilderTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsBuilderBuiltLineWayCorrectly()
        {
            RutWayBuilder wayBuilder = new RutWayBuilder();
            Director director = new Director(wayBuilder);

            PointCommunications.points.Clear();
            use_coef_comm.Clear();
            wayBuilder.wayA.Clear();
            wayBuilder.wayB.Clear();
            wayBuilder.fork.Clear();
            wayBuilder.resultWay.resultPoints.Clear();
            bufferPoints.Clear();

            List<Point> points = new List<Point>();
            for (int i = 0; i < 4; i++)
                points.Add(new Point($"{i}"));

            points[0].coef_comm = new List<int> { 0 };
            points[1].coef_comm = new List<int> { 0, 1 };
            points[2].coef_comm = new List<int> { 1, 2 };
            points[3].coef_comm = new List<int> { 2 };

            PointCommunications.points = points;

            director.Construct(points[0], points[2]);

            List<Point> expectedWay = new List<Point>() { points[0], points[1], points[2] };
            List<Point> actualWay = wayBuilder.resultWay.resultPoints;

            Assert.AreEqual(expectedWay, actualWay);
        }
        [Test]
        public void IsBuilderBuiltForkWayCorrectly()
        {
            RutWayBuilder wayBuilder = new RutWayBuilder();
            Director director = new Director(wayBuilder);

            PointCommunications.points.Clear();
            use_coef_comm.Clear();
            wayBuilder.wayA.Clear();
            wayBuilder.wayB.Clear();
            wayBuilder.fork.Clear();
            wayBuilder.resultWay.resultPoints.Clear();
            bufferPoints.Clear();

            List<Point> points = new List<Point>();
            for (int i = 0; i < 4; i++)
                points.Add(new Point($"{i}"));

            points[0].coef_comm = new List<int> { 0 };
            points[1].coef_comm = new List<int> { 0, 1, 3 };
            points[2].coef_comm = new List<int> { 1 };
            points[3].coef_comm = new List<int> { 3 };

            PointCommunications.points = points;

            director.Construct(points[0], points[3]);

            List<Point> expectedWay = new List<Point>() { points[0], points[1], points[3] };
            List<Point> actualWay = wayBuilder.resultWay.resultPoints;

            Assert.AreEqual(expectedWay, actualWay);
            
        }
        [Test]
        public void IsBuilderBuiltCircleWayCorrectly()
        {
            RutWayBuilder wayBuilder = new RutWayBuilder();
            Director director = new Director(wayBuilder);

            PointCommunications.points.Clear();
            use_coef_comm.Clear();
            wayBuilder.wayA.Clear();
            wayBuilder.wayB.Clear();
            wayBuilder.fork.Clear();
            wayBuilder.resultWay.resultPoints.Clear();
            bufferPoints.Clear();

            List<Point> points = new List<Point>();
            for (int i = 0; i < 5; i++)
                points.Add(new Point($"{i}"));

            points[0].coef_comm = new List<int> { 0, 1 };
            points[1].coef_comm = new List<int> { 0, 2 };
            points[2].coef_comm = new List<int> { 2, 3 };
            points[3].coef_comm = new List<int> { 3, 4 };
            points[4].coef_comm = new List<int> { 1, 4 };

            PointCommunications.points = points;

            director.Construct(points[0], points[3]);

            List<Point> expectedWay = new List<Point>() { points[0], points[1], points[3] };
            List<Point> actualWay = wayBuilder.resultWay.resultPoints;

            Assert.AreEqual(expectedWay, actualWay);

        }
    }
}