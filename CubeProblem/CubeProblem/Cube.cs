using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeProblem
{
    [TestClass]
    public class Cube
    {
        [TestMethod]
        public void CalculateCube()
        {
            Assert.AreEqual(7077888, CalculateCube192(192));
        }
        public int CalculateCube192(int number)
        {
            int k = 192;

            return k *= k * k;

        }
    }
}
