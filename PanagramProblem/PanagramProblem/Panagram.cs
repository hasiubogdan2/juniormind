using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PanagramProblem
{
    [TestClass]
    public class Panagram
    {
        [TestMethod]
        public void CalculateIfPanagram()
        {
            Assert.AreEqual(false, FindIfPanagram("b     c"));

        }
        [TestMethod]
        public void CalculateIfPanagramSentence()
        {
            Assert.AreEqual(true, FindIfPanagram("The quick brown fox jumps over the lazy dog"));

        }
        [TestMethod]
        public void CalculateIfPanagramLetters()
        {
            Assert.AreEqual(true, FindIfPanagram("abcdefghijklmnopqrstuvwxyz"));
        }
        [TestMethod]
        public void CalculatePanagram()
        {
            Assert.AreEqual(false, FindIfPanagram("We love coding"));
        }
        public bool FindIfPanagram(string sentence)
        {
            string lowerCaseTransform = sentence.ToLower();
            if (CheckIfPanagram(lowerCaseTransform))
                return true;
            else return false;
        }

        public bool CheckIfPanagram(string panagram)
        {
            int j = 0;
            for (int i = 0; i < panagram.Length; i++)
            {
                while ((char)('a' + j) != panagram[i])
                {
                    j++;
                    return false;
                }
            }
            return true;

        }

    }
}

