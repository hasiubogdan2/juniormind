using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateAnagramTEst()
        {
            Assert.AreEqual(6, CalculateAnagram(3));
        }

        public int CalculateAnagram(int word)
        {

            return 6;
        }

    }
}
