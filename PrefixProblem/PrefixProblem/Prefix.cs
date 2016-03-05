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
            Assert.AreEqual("aaa", CalculatePrefix("aaabba", "aaaaaabb"));
        }
        [TestMethod]
        public void FindCommonPrefix2()
        {
            Assert.AreEqual("aba", CalculatePrefix("abaa", "abab"));
        }
        [TestMethod]
        public void FindCommonPrefix3()
        {
            Assert.AreEqual("ab", CalculatePrefix("abbaaaaa", "abaaaaaa"));
        }
        public string CalculatePrefix(string firstWord, string secondWord)
        {

            string commonPrefix = string.Empty;

            for (int i = 0; i < firstWord.Length && i < secondWord.Length; i++)
            {
                if (firstWord[i] != secondWord[i]) break;

                else 
                    commonPrefix += firstWord[i]; 

            }

            return commonPrefix;

        }
    }
}  