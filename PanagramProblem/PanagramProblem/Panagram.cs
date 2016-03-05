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
            Assert.AreEqual("YES", FindPanagram("The quick brown fox jumps over the lazy dog"));

        }

        public string FindPanagram(string panagram)
        {
            string result = string.Empty;
            string[] alphabet = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k",
        "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w",
        "x", "y", "z"};
            
            for(int i = 0; i< panagram.Length; i++)
            {
                while (panagram.Length != alphabet.Length)
                {
                    return "NO";
                }

            }return "YES";


        }




    }


}

