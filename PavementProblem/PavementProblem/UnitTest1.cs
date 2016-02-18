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
        [TestMethod]
        public void PavementSecondTest()
        {
            Assert.AreEqual(4, getStonePieces(4,4,2));
        }
        public double getStonePieces( int heightOfTheMarket, int widthOfTheMarket, int heightOfTheCubicStone)
        {

            double ariaOfTheMarket = heightOfTheMarket * widthOfTheMarket;
            double  ariaOfTheCubic = heightOfTheCubicStone * heightOfTheCubicStone;

            int cubicStonesnedeed = ((heightOfTheMarket/heightOfTheCubicStone)+1) * ((widthOfTheMarket/heightOfTheCubicStone)+1);
            
            return cubicStonesnedeed;
        }

    }


}
