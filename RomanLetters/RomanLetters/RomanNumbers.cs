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
            Assert.AreEqual("XC",FindTheRomanNumbers(90));
        }

       
        public string FindTheRomanNumbers(int number)
        {
            string result = "";
            string[] romanNumbers = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C" };
            int[] numbers = { 1, 4, 5, 9, 10, 40, 50, 90, 100 };
            
                for (int i = romanNumbers.Length - 1; i >= 0; i--)
                {
                    while (number - numbers[i] >= 0)
                    {

                        number =number-numbers[i];
                        result = result+romanNumbers[i];
                    }
                }      return result;       
            }

        }    

    }

