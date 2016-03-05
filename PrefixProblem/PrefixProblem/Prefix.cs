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

        public string CalculatePrefix(string firstWord, string secondWord)
        {
            int factorial = 0;
            string commonPrefix = string.Empty;
            int i = 0;
            return "";
        }
    }

}