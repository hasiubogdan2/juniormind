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
            Assert.AreEqual("No,its not a panagram", FindIfPanagram("b     c"));

        }
        [TestMethod]
        public void CalculateIfPanagramSentence()
        {
            Assert.AreEqual("Yes,its a panagram", FindIfPanagram("The quick brown fox jumps over the lazy dog"));

        }
        [TestMethod]
        public void CalculateIfPanagramLetters()
        {
            Assert.AreEqual("Yes,its a panagram", FindIfPanagram("abcdefghijklmnopqrstuvwxyz"));
        }
        public string FindIfPanagram(string sentence)
        {
            string lowerCaseTransform = sentence.ToLower();
            if (CheckIfPanagram(lowerCaseTransform))
                return "Yes,its a panagram";
            else return "No,its not a panagram";
        }

        public bool CheckIfPanagram(string panagram)
        {
            string[] alphabet = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k",
        "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w",
        "x", "y", "z"};


            for (int i = 0; i < alphabet.Length; i++)
            {
                while ((char)('a' + i) != panagram[i])
                {
                    i++;
                    return false;
                }



            } return true;


}

    }
}

