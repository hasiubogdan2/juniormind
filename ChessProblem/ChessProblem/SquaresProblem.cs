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
