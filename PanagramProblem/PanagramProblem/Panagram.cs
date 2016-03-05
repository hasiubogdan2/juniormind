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
            Assert.AreEqual("NO", FindPanagram("The quick brown fox jumps over the lazy dog"));

        }

        public string FindPanagram(string panagram)
        {
            string result = string.Empty;

            return "NO";

        }

    }
}
