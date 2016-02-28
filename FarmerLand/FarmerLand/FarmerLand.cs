using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmerLand
{
    [TestClass]
    public class FarmerLand
    {
        [TestMethod]
        public void CalculateAtSmallerScale()
        {
            Assert.AreEqual(4,CalculateTheLand(10, 3));
        }
        [TestMethod]
        public void CalculateProblemDates()
        {
            Assert.AreEqual(592900, CalculateTheLand(770000, 230));
        }

        public double CalculateTheLand(double areaOfTheNewLand, double extraWidth)
        {
            double initialLength;

            double multiplier = extraWidth * extraWidth + 4 * areaOfTheNewLand;

            if (multiplier > 0)
            {
                initialLength = (-extraWidth + Math.Sqrt(multiplier)) / 2;

                return initialLength*initialLength;
            } return 0;
            
        }

    }

}
