using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrefixProblem
{
    [TestClass]
    public class Prefix
    {
        [TestMethod]
        public void FindCommonPrefix()
        {
            Assert.AreEqual("", CalculatePrefix("",""));
        }
        [TestMethod]
        public void CalculateFactorialTest()
        {
            Assert.AreEqual(6, CalculateFactorial(3));
        }
        [TestMethod]
        public void CalculateFactorialTest2()
        {
            Assert.AreEqual(120, CalculateFactorial(5));
        }
        public string CalculatePrefix(string firstWord, string secondWord)
        {
            int factorial = 0;
            string commonPrefix = string.Empty;
            int i = 0;
            
            return "";
        }
        public int CalculateFactorial(int factNumber)
        {
            int factorial = 1;
            int i = factNumber;
            while (factNumber >= 1)
            {
                factorial *= factNumber ;
                factNumber--;
            }
            return factorial;
        }
    }

}