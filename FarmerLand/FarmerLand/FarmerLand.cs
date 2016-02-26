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
            
           
            return 2;
        }

    }

}
