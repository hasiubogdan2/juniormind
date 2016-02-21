using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportManProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { Assert.AreEqual(1,howManyLapsDoesTheSportman(1,1));
}
        public int howManyLapsDoesTheSportman(int laps,int rounds)
        {

            laps = rounds;

            int result = laps * rounds;


            return result;
        }

    }

}
