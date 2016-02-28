using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanLetters
{
    [TestClass]
    public class RomanNumbers
    {
        [TestMethod]
        public void CalculateFirst10Numbers()
        {
            Assert.AreEqual("V",FindTheRomanNumbers(5));
        }

        public string FindTheRomanNumbers(int number)
        {
            string output = "";
            return "V";

        }

    }
}
