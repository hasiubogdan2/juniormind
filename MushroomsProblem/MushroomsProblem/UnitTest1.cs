﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MushroomsProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual( 100 , howManyRedMushroomsare(10,110));

        }
        [TestMethod]
        public void MyTestMethod()
        {
            Assert.AreEqual(167, howManyRedMushroomsare(5, 200));

        }
        public int howManyRedMushroomsare( int xCoef, int totalNumberOfMushrooms)

        {
            
           int whiteMushrooms = totalNumberOfMushrooms / (xCoef + 1);

           int redMushrooms = totalNumberOfMushrooms - whiteMushrooms;

            return redMushrooms;
        }


    }
}
