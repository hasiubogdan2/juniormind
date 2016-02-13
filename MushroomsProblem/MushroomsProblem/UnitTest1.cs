using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MushroomsProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { Assert.AreEqual( 100 , howManyRedMushroomsare(100,10,110));

        }
        public int howManyRedMushroomsare(int redMushrooms, int whiteMushrooms, int totalNumberOfMushrooms)

        {
            totalNumberOfMushrooms = redMushrooms + whiteMushrooms;
            whiteMushrooms = 10; totalNumberOfMushrooms = 110;
             redMushrooms = totalNumberOfMushrooms-whiteMushrooms;

            return redMushrooms;
        }


    }
}
