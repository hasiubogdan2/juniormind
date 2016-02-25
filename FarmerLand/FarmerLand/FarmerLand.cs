using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmerLand
{
    [TestClass]
    public class FarmerLand
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0,CalculateTheLand(770000, 230));
        }

        public double CalculateTheLand(double areaOfTheNewLand, double extraWidth)
        {

            return 0;
        }

    }

}
