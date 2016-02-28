using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanLetters
{
    [TestClass]
    public class RomanNumbers
    {
        [TestMethod]
        public void RevealNumber5Test()
        {
            Assert.AreEqual("V",FindTheRomanNumbers(5));
        }

        [TestMethod]
        public void RevealNumber10Test()
        {
            Assert.AreEqual("X", FindTheRomanNumbers(10));
        }
        [TestMethod]
        public void RevealNumber9Test()
        {
            Assert.AreEqual("IX", FindTheRomanNumbers(9));
        }
        [TestMethod]
        public void RevealNumber11Test()
        {
            Assert.AreEqual("XI", FindTheRomanNumbers(11));
        }
        public string FindTheRomanNumbers(int number)
        {
            string theNumberIs = "";
            if (number == 1) return  "I";
            if (number == 2) return  "II";
            if (number == 3) return  "III";
            if (number == 4) return  "IV";
            if (number == 5) return  "V";
            if (number == 6) return  "VI";
            if (number == 7) return  "VII";
            if (number == 8) return  "VIII";
            if (number == 9) return  "IX";
            if (number == 10) return  "X";
            if (number == 11) return "X" + "I";


            return "not good";

        }    

    }
}
