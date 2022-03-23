using Microsoft.VisualStudio.TestTools.UnitTesting;
using DirectionsAB;
using static DirectionsAB.PointCommunications;
using System.Collections.Generic;

namespace DirectionsABTests
{
    [TestClass]
    public class PointCommunicationsTests
    {
        [TestMethod]
        public void IsReallyCommunicatedRegions()
        {
            //arrange
            Point a = new Point();
            Point b = new Point();
            a.coef_comm = new List<int>() { 3, 6, 8 };
            b.coef_comm = new List<int>() { 3, 5, 9 };
            bool expected = true;

            //act
            bool actual = PointCommunications.IsCommunicated(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsNotReallyCommunicatedRegions()
        {
            //arrange
            Point a = new Point();
            Point b = new Point();
            a.coef_comm = new List<int>() { 7, 6, 8 };
            b.coef_comm = new List<int>() { 4, 5, 9 };
            bool expected = false;

            //act
            bool actual = PointCommunications.IsCommunicated(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsReallyCommunicatedTwoIntersectedId()
        {
            //arrange
            Point a = new Point();
            Point b = new Point();
            a.coef_comm = new List<int>() { 7, 6, 8 };
            b.coef_comm = new List<int>() { 6, 5, 7, 4 };
            bool expected = true;

            //act
            bool actual = PointCommunications.IsCommunicated(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
