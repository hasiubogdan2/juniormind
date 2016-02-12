using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrainProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, BirdDistance(10,0));
        }
        public int BirdDistance(int distance, int answer)
        {
            answer = 0;
            answer = distance / 2;
            

            return answer;
        }
    }
}
