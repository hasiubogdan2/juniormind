﻿using System;
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
            double initialLength;

            double multiplier = extraWidth * extraWidth + 4 * areaOfTheNewLand;

            if (multiplier > 0)
            {
                initialLength = (-extraWidth + Math.Sqrt(multiplier)) / 2;

                return initialLength;
            } else return 0;
            
        }

    }

}
