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
            int  multiplier= 0;
            while((cube % 1000 != 888)&&(multiplier!=number))
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
