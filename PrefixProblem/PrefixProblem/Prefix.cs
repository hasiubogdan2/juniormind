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
            Assert.AreEqual("aaa", CalculatePrefix("aaa", "aaa"));
        }

        public string CalculatePrefix(string firstWord, string secondWord)
        {

            string commonPrefix = string.Empty;

            for (int i = 1; i < firstWord.Length && i < secondWord.Length && firstWord[i] == secondWord[i]; i++)
            {

                commonPrefix += firstWord[i];
            }

            return commonPrefix;

        }
    }
}  