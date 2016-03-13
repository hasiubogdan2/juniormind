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
        public void CalculateForFirst26Columns2()
        {
            Assert.AreEqual("W", CalculateColumn(23));
        }
        [TestMethod]
        public void CalculateForBiggerThan26()
        {
            Assert.AreEqual("Z", CalculateColumn(26));
        }
        [TestMethod]
        public void CalculateForNumber27()
        {
            Assert.AreEqual("AA", CalculateColumn(27));
        }
        [TestMethod]
        public void CalculateForBigger2()
        {
            Assert.AreEqual("X", CalculateColumn(24));
        }
        [TestMethod]
        public void CAlculateForBigger()
        {
            Assert.AreEqual("AB", CalculateColumn(28));
        }

        public string CalculateColumn(int numberInserted)
        {
            int i = 0;
            string output = string.Empty;
            
            while(numberInserted>0)
            {
                numberInserted--;

                output= TransformToChar(numberInserted % 26) + output;
                numberInserted /= 26;
            }
            return output;
     

            
        }

        private static char TransformToChar(int numberInserted)
        {
            return ((char)('A' + numberInserted));
        }
    }

}