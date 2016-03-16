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
        [TestMethod]
        public void CalculateDIstinct()
        {
            Assert.AreEqual(2, GetRepetition('a',"aab"));
        }
       
        public int CalculateAnagram(string word)
        {
            int result = 1;
            string LowerCase = word.ToLower();
           for(int i='a'; i<='z'; i++)
            {
                result =result* Factorial(GetRepetition((char)i, word)) ;
            }return result;
                
        }
        int GetRepetition(char letterIntroduced, string word)
        {
            int countWord = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (letterIntroduced == word[i])
                    countWord++;
            }
            return countWord;
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
