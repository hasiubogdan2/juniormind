using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DebtProblem
{
    [TestClass]
    public class Debt
    {
        [TestMethod]
        public void CalculateFirstPenalty()
        {
            Assert.AreEqual(0,CalculateTotalSumOfRent(100,5));
        }

        public decimal CalculateTotalSumOfRent(decimal rent,int extraDays)
        {

            return 0;
        }
    }
}
