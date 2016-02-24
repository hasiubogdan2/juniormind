using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WatermelonProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(true, CalculateIfTheWatermelonIsShared(20));

        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(false, CalculateIfTheWatermelonIsShared(21));
        }


        Boolean CalculateIfTheWatermelonIsShared(int watermelonKgs)
        {
            if ((watermelonKgs > 3)&&(watermelonKgs%2==0))
            {
                return true;

            }    else return false;

            
          
        }
    }
}
