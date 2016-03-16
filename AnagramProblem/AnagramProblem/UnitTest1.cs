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
            Assert.AreEqual(1, CalculateAnagram("aaa"));
        }
        [TestMethod]
        public void CalculateAnagramWithSameLetters2()
        {
            Assert.AreEqual(1, CalculateAnagram("bbbb"));
        }
        [TestMethod]
        public void CalculateAnagramWithSameLettersUpper()
        {
            Assert.AreEqual(1, CalculateAnagram("AA"));
        }
        [TestMethod]
        public void CalculateDIstinct()
        {
            Assert.AreEqual(2, GetRepetition('a',"aab"));
        }
        [TestMethod]
        public void CalculateRepetition()
        {
            Assert.AreEqual(4, GetRepetition('b', "abababab"));
        }
        [TestMethod]
        public void CalculateAComplicatedAngram()
        {
            Assert.AreEqual(6, CalculateAnagram("abc"));
        }
        [TestMethod]
        public void CalculateAnagram()
        {
            Assert.AreEqual(12, CalculateAnagram("abcd"));
        }
        public int CalculateAnagram(string word)
        {
            int result = 1;
           
           for(int i='a'; i<='z'; i++)
            {
                result =result* Factorial(GetRepetition((char)i, word)) ;
            }return (Factorial(word.Length)) / result;

        }
        int GetRepetition(char letterIntroduced, string word)
        {
            int countWord = 0;
            string LowerCase = word.ToLower();
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
