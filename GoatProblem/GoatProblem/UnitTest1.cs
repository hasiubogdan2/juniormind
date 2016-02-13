using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoatProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual(25, kgOfFayEatenbyqGoats(1, 1, 1, 5, 5));
        

        }
        public double kgOfFayEatenbyqGoats(double xDays, int yGoats, double zKG, int qGoats, double wDays)
        {
            double kgOfFay = 0;

            kgOfFay = (wDays * qGoats * zKG) / (xDays * yGoats);

            return kgOfFay;
        }
    }
}
