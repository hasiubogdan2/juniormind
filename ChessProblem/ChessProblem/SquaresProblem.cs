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
            int result = squares * squares+1;

            return result;

        }
    }
}
