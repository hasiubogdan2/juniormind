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
            Assert.AreEqual(true, FindPanagram("b     c"));

        }
        [TestMethod]
        public void CalculateIfPanagramSentence()
        {
            Assert.AreEqual(true, FindPanagram("The quick brown fox jumps over the lazy dog"));
        }

        public bool FindPanagram(string panagram)
        {
            string[] alphabet = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k",
        "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w",
        "x", "y", "z"};


            for (int i = 0; i < alphabet.Length; i++)
            {
                if ((char)('a') == panagram[i]) return true;
                if ((char)('b') == panagram[i]) return true;
                if ((char)('c') == panagram[i]) return true;
                if ((char)('d') == panagram[i]) return true;
                if ((char)('e') == panagram[i]) return true;
                if ((char)('f') == panagram[i]) return true;
                if ((char)('g') == panagram[i]) return true;
                if ((char)('h') == panagram[i]) return true;
                if ((char)('i') == panagram[i]) return true;
                if ((char)('j') == panagram[i]) return true;
                if ((char)('k') == panagram[i]) return true;
                if ((char)('l') == panagram[i]) return true;
                if ((char)('m') == panagram[i]) return true;
                if ((char)('n') == panagram[i]) return true;
                if ((char)('o') == panagram[i]) return true;
                if ((char)('p') == panagram[i]) return true;
                if ((char)('q') == panagram[i]) return true;
                if ((char)('r') == panagram[i]) return true;
                if ((char)('s') == panagram[i]) return true;
                if ((char)('t') == panagram[i]) return true;
                if ((char)('u') == panagram[i]) return true;
                if ((char)('v') == panagram[i]) return true;
                if ((char)('w') == panagram[i]) return true;
                if ((char)('x') == panagram[i]) return true;
                if ((char)('y') == panagram[i]) return true;
                if ((char)('z') == panagram[i]) return true;

            } return false;


}

    }
}

