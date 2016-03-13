using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeProblem
{
    [TestClass]
    public class Cube
    {
        [TestMethod]
        public void CalculateCube192()
        {
            Assert.AreEqual(192, CalculateCube(1));
        }
        [TestMethod]
        public void CalculateCube442()
        {
            Assert.AreEqual(442, CalculateCube(2));
        }
        [TestMethod]
        public void CalculateCube692()
        {
            Assert.AreEqual(692, CalculateCube(3));
        }
        public int CalculateCube(int number)
        {

            int i = 1;
            int cube = 0;
            int  multiplier= 0;
            while((cube % 1000 != 888)||(multiplier!=number))
            {
                i++;
                cube = i*i*i;
                if ((cube % 1000 == 888))

                    multiplier++;
                   
            }
            return i;

        } 
    }
}
