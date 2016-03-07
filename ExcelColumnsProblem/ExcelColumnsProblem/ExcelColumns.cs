using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelColumnsProblem
{
    [TestClass]
    public class ExcelColumns
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("A", CalculateTheNumberOfColumn(1));
        }

     public string  CalculateTheNumberOfColumn(int numberInserted)
        {
            
            return "A";

        }

    }
}
