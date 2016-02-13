using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MushroomsProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { Assert.AreEqual( 100 , howManyRedMushroomsare(10,110));

        }
        public int howManyRedMushroomsare( int xCoef, int totalNumberOfMushrooms)

        {
            int redMushrooms = 0; int whiteMushrooms = 0;

            redMushrooms = xCoef * whiteMushrooms;
            totalNumberOfMushrooms = redMushrooms + whiteMushrooms;
            totalNumberOfMushrooms = whiteMushrooms + xCoef * whiteMushrooms;
            totalNumberOfMushrooms = whiteMushrooms*(xCoef + 1);
            whiteMushrooms = totalNumberOfMushrooms / (xCoef + 1);

            return redMushrooms;
        }


    }
}
