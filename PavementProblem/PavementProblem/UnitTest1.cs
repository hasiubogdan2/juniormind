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
        public double getStonePieces( double heightOfTheMarket, double widthOfTheMarket, double heightOfTheCubicStone)
        {
            double ariaOfTheMarket = 0;  double   ariaOfTheCubic = 0; double cubicStonesnedeed;

            ariaOfTheMarket = heightOfTheMarket * widthOfTheMarket;
            ariaOfTheCubic = heightOfTheCubicStone * heightOfTheCubicStone;

            cubicStonesnedeed = ((heightOfTheMarket/heightOfTheCubicStone)+0.5) * ((widthOfTheMarket/heightOfTheCubicStone)+0.5);
            


            return cubicStonesnedeed;
        }

    }


}
