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
            Assert.AreEqual(2,CalculateTheLand(10, 3));
        }

        public double CalculateTheLand(double areaOfTheNewLand, double extraWidth)
        {
            double initialLength=0;

            double multiplier = extraWidth * extraWidth + 3 * areaOfTheNewLand;

            if (multiplier > 0)
            {
                initialLength = Math.Sqrt(areaOfTheNewLand - extraWidth * initialLength);

                return initialLength;
            } else return 0;
            
        }

    }

}
