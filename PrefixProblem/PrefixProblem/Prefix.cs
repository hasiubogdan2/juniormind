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