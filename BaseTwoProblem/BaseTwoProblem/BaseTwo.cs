using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseTwoProblem
{
    [TestClass]
    public class BaseTwo
    {
        [TestMethod]
        public void TestMethod()
        {
            CollectionAssert.AreEqual(new byte[]{0,1,0},Convert(2));
            CollectionAssert.AreEqual(new byte[] { 1,0, 0 }, Convert(4));


        }
        byte[] Convert(int number)
        {
            byte[] result = { 0, 1, 0 };
            return result;        }

    } 
}
