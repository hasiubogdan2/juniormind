using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelProblem
{
    [TestClass]
    public class Excel
    {
        [TestMethod]
        public void FindTheColumn()
        {
            Assert.AreEqual("A", CalculateColumn(1));
        }

        public string CalculateColumn(int numberInserted)
        {
            return "A";
        }
    }
}
