using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankRatePRoblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, bankRatePayedIntheFourthYear3Month(8.000,4.7,4));
        }

        public double bankRatePayedIntheFourthYear3Month( double creditBank, double anualRate, double period)  {

            double ratePayedIn4Year3Month = 0;

            ratePayedIn4Year3Month = creditBank * anualRate * period;

            return ratePayedIn4Year3Month;
            }




    }
}
