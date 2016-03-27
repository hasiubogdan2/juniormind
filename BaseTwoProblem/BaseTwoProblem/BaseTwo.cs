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
        
        }
        byte[] Convert(int number)
        {
            byte[] result = { 0, 1, 0 };
            return result;        }

    } 
}
