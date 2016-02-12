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

            Assert.AreEqual(5, KGgoatsEat(1, 1, 1, 5, 5));
        }

        public double KGgoatsEat(double Xdays, int Ygoats, double zKG, int Qgoats, double Wdays)
        {
            double kgOfFay = 0;

            kgOfFay = (Xdays * Qgoats * zKG) / (Wdays * Ygoats);

            return kgOfFay;
        }
    }
}
