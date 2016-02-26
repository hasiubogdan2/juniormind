using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DebtProblem
{
    [TestClass]
    public class Debt
    {
        [TestMethod]
        public void CalculateFirstDaysPenalty()
        {
            Assert.AreEqual(102,CalculateTotalSumOfRent(100,5));
        }
        [TestMethod]
        public void CalculateSecondIntervalDaysPenalty()
        {
            Assert.AreEqual(105, CalculateTotalSumOfRent(100, 20));
        }

        public double CalculateTotalSumOfRent(int rent,int extraDays)
        {
            
            

            double penalty1 = 0.02 * rent;
            double penalty2 = 0.05 * rent;
            
            double totalSumOfRent =  rent + penalty1;
            double totalSumOfRent2 = rent + penalty2;
            if ((extraDays >= 1) && (extraDays <= 10)) return totalSumOfRent;
            if ((extraDays >= 11) && (extraDays <= 30)) return totalSumOfRent2;
            else return 0;   
        }
    }
}
