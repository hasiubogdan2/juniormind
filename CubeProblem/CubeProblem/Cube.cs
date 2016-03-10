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
            
            int i = 192;
            int cube = i*i*i;

            if (cube % 1000 == 888)
            {
                i++;
                cube = i*i*i;
            }

            return i;
        } 
    }
}
