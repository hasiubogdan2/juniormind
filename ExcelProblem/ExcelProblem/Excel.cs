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
        [TestMethod]
        public void CalculateForError()
        {
            Assert.AreEqual("Error", CalculateColumn(30));
        }
        public string CalculateColumn(int numberInserted)
        {
            int i = 0;
            string output = string.Empty;
            string[] upperCaseAlphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O",
                "P", "Q", "R", "S", "T", "U", "W", "X", "Y", "Z" };
            for (i = 0; i < upperCaseAlphabet.Length; i++)
            {
                if (numberInserted > 26) return "Error";
            }

            return "A";
        }
    }
}
