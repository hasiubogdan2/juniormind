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

            string result = string.Empty;
            string[] romanNumbers = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C" };
            int[] numbers = { 1, 4, 5, 9, 10, 40, 50, 90, 100 };

           for(int i = numbers.Length-1; i <=100; i--)
            {
                while(number-numbers[i]>=0)
                {
                    result = number + romanNumbers[i];
                    number = number - numbers[i];
                }

            }return result;
                





        }    

    }
}
