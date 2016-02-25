using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WatermelonProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateWithEvenNumberOfKgs()
        {
            Assert.AreEqual("YES", CalculateIfTheWatermelonIsShared(20));

        }
        [TestMethod]
        public void CalculateWithNotEvenNumbersOfKgs()
        {
            Assert.AreEqual("NO", CalculateIfTheWatermelonIsShared(21));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual("YES", CalculateIfTheWatermelonIsShared(22));
        }
       public string CalculateIfTheWatermelonIsShared(int watermelonKgs)
        {
            string verifyTheConditions = "";

            if ((watermelonKgs > 3) && (watermelonKgs % 2 == 0)) return "YES";
            if ((watermelonKgs > 3) && (watermelonKgs % 2 == 1)) return "NO";

            return verifyTheConditions;

          }
    }
}
