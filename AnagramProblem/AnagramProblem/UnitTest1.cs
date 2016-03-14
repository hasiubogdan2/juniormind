using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateAnagramWithSameLetters()
        {
            Assert.AreEqual(6, CalculateAnagram("aaa"));
        }
        [TestMethod]
        public void CalculateAnagramWithSameLetters2()
        {
            Assert.AreEqual(24, CalculateAnagram("bbbb"));
        }
        [TestMethod]
        public void CalculateAnagramWithSameLettersUpper()
        {
            Assert.AreEqual(2, CalculateAnagram("AA"));
        }
        public int CalculateAnagram(string word)
        {
            int result = 1;
            string LowerCase = word.ToLower();
           for(int i='a'; i <= 'z'; i++)
            {
                result = Factorial(i);
            }return result;
                
        }

        int Factorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }

            return result;

        }

    } 
}
