using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MushroomsProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { Assert.AreEqual( 100 , howManyRedMushroomsare(100,10));

        }
        public int howManyRedMushroomsare(int redMushrooms, int whiteMushrooms)
        {
            int x = 10;

            redMushrooms = whiteMushrooms * x;

            return redMushrooms;
        }


    }
}
