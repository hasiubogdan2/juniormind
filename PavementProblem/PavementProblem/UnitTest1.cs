using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PavementProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4,getStonePieces(6,6,4));

        }
        public double getStonePieces( int heightOfTheMarket, int widthOfTheMarket, int heightOfTheCubicStone)
        {
            int ariaOfTheMarket = 0;  int   ariaOfTheCubic = 0; int cubicStonesnedeed;

            ariaOfTheMarket = heightOfTheMarket * widthOfTheMarket;
            ariaOfTheCubic = heightOfTheCubicStone * heightOfTheCubicStone;

            cubicStonesnedeed = ((heightOfTheMarket/heightOfTheCubicStone)+1) * ((widthOfTheMarket/heightOfTheCubicStone)+1);
            


            return cubicStonesnedeed;
        }

    }


}
