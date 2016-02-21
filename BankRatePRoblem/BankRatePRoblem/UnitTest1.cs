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
            decimal rate = bankRatePayedIntheFourthYear3Month(100, 1, 12, 1);
            Assert.AreEqual(101, rate);
        }

        public decimal bankRatePayedIntheFourthYear3Month( decimal creditBank, int period, decimal ratePerYear, int currentMonth)  {

            

            return creditBank/period + creditBank*ratePerYear/12/100;
            }




    }
}
