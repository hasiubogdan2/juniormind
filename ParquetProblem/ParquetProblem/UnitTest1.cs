using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParquetProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2.55,CalculateParquet(3,2,2,1));

        }

    public double CalculateParquet( double nLengthOfTheRoom, double mWidthOfTheRoom, double aLengthOfTheParquet, double bWidthOfTheParquet)
        {
            double AreaRoom = nLengthOfTheRoom * mWidthOfTheRoom;
            double AreaParquet = aLengthOfTheParquet * bWidthOfTheParquet;
            double CalculateParquetPieces = AreaRoom / AreaParquet;
            
            double calculateParquet = CalculateParquetPieces - CalculateParquetPieces*15/100;
            return calculateParquet ;

        }
            
            }
}
