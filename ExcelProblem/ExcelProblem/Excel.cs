﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelProblem
{
    [TestClass]
    public class Excel
    {
        [TestMethod]
        public void FindTheColumn()
        {
            Assert.AreEqual("B", CalculateColumn(1));
        }
        
        [TestMethod]
        public void CalculateForFirst26Columns()
        {
            Assert.AreEqual("A", CalculateColumn(0));
        }
        [TestMethod]
        public void CalculateForFirst26Columns2()
        {
            Assert.AreEqual("X", CalculateColumn(23));
        }
        [TestMethod]
        public void CalculateForBiggerThan26()
        {
            Assert.AreEqual("Error", CalculateColumn(26));
        }
        [TestMethod]
        public void CalculateForNumber27()
        {
            Assert.AreEqual("AA", CalculateColumn(27));
        }
        [TestMethod]
        public void CalculateForBigger2()
        {
            Assert.AreEqual("Z", CalculateColumn(25));
        }
        [TestMethod]
        public void CAlculateForBigger()
        {
            Assert.AreEqual("BC", CalculateColumn(27));
        }

        public string CalculateColumn(int numberInserted)
        {
            int i = 0;
            string output = string.Empty;
            string[] upperCaseAlphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O",
                "P", "Q", "R", "S", "T", "U", "W", "X", "Y", "Z" };
            for (i = 0; i < upperCaseAlphabet.Length; i++)
            {
                if (numberInserted >= 0 && numberInserted < 26)
                    return ((char)('A' + numberInserted)).ToString();
                else if (numberInserted > 26)
                {
          return CalculateColumn(numberInserted / 26) + CalculateColumn(numberInserted % 26 + 1);
               
                }
            }

                return "Error";
        }
    }

}