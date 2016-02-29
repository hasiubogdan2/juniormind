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

       
        public string FindTheRomanNumbers(int number)
        {

            string result = "";
            string[] romanNumbers = { "I","IV","V","IX","X" };
            int[] numbers = { 1, 4, 5, 9, 10 };

           for(int i = numbers.Length; i <= 11; i++)
                while()





        }    

    }
}
