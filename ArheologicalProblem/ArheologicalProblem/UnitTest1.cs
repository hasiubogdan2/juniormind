using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArheologicalProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2,CalculateMinimumArea(1,1,3,2,3,4));


        }

        [TestMethod]
        public void MyTestMethod2()
        {
            Assert.AreEqual(2, CalculateMinimumArea(5, 7, 3, 2, 3, 4));
        }
        public float CalculateMinimumArea(float XofA, float YofA,float XofB,float YofB,float XofC,float YofC)
        {
            float delta = XofA * YofB + XofB * YofC + XofC * YofA - YofB * XofC - YofC * XofA - YofA * XofB;

            return delta / 2;
        }
    }
}
