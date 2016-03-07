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
            Assert.AreEqual(true, FindPanagram("ab"));

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

            } return false;


}

    }
}

