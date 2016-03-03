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
            Assert.AreEqual("", CalculatePrefix(""));
        }

        public string CalculatePrefix(string comparison)
        {
            string FirstString = string.Empty;
            string SecondString = string.Empty;
            return "";
        }
    }

}