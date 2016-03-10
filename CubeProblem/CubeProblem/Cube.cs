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
            Assert.AreEqual(192, CalculateCube192(1));
        }
        public int CalculateCube192(int number)
        {

            int i = 1;
            int cube = i*i*i;

            while((cube % 1000 == 888)&&(i<number))
            {
                i++;
                cube = i*i*i;
            }

            return i;
        } 
    }
}
