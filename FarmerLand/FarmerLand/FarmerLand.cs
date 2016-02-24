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
            Assert.AreEqual(0,CalculateTheLand(100,100));
        }

        public double CalculateTheLand(double lengthOfTheLand,double areaOfTheNewLand)
        {
            return 0;
        }

    }

}
