using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankRatePRoblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void rateForFirstMonth()
        {
            decimal rate = CalculateBankRate(100, 1, 12, 1);
            Assert.AreEqual(101, rate);
        }

        [TestMethod]
        public void rateForSecondMonth()
        {
            decimal rate = CalculateBankRate(100, 1, 12, 2);
            Assert.AreEqual(100, rate);
        }
        
        [TestMethod]
            public void rateForThirdMonthInTheFourthYear()
        {
            decimal rate = CalculateBankRate(96, 48, 12, 3);
            Assert.AreEqual(3.6m, rate);
        }

         decimal CalculateBankRate(decimal creditBank, int period, decimal ratePerYear, int currentMonth)
        {

            decimal principal = creditBank / period;
            decimal exacInterestPerMonth = ratePerYear / 12 / 100;
            decimal sold = creditBank - (currentMonth - 1) * principal;
            return principal +sold * exacInterestPerMonth;
        }
    }
}
