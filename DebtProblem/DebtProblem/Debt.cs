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
            Assert.AreEqual(100.4,CalculateTotalSumOfRent(100,5));
        }

        public double CalculateTotalSumOfRent(int rent,int extraDays)
        {
            
            double rentPerDay = rent / extraDays;
            double penalty = 0.02 * rentPerDay;
            double totalSumOfRent =  rent + penalty;
            if ((extraDays >= 1) && (extraDays <= 10)) return totalSumOfRent;

             else return 0;   
        }
    }
}
