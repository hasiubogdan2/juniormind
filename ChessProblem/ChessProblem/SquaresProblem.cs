using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessProblem
{
    [TestClass]
    public class SquaresProblem
    {
        [TestMethod]
        public void CalculateChessTable2x2()
        {
            Assert.AreEqual(5, CalculateNumberOfSquares(2));
        }
        [TestMethod]
        public void CalculateChessTable3x3()
        {
            Assert.AreEqual(14, CalculateNumberOfSquares(3));
        }
        [TestMethod]
        public void CalculateChessTable4X4()
        {
            Assert.AreEqual(30, CalculateNumberOfSquares(4));
        }
        [TestMethod]
        public void CalculateChessTable5x5()
        {
            Assert.AreEqual(55, CalculateNumberOfSquares(5));
        }
        [TestMethod]
        public void CalculateChessTable8x8()
        {
            Assert.AreEqual(204, CalculateNumberOfSquares(8));
        }
        public int CalculateNumberOfSquares(int squares)
        {
            int result = 0;
            while(squares>0)
            {
                result = result+(squares * squares);
                squares--;
            }
            return result;

        }
    }
}
