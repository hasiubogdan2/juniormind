using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportManProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void firstLap()
        { Assert.AreEqual(1,howManyLapsDoesTheSportman(1,1));

}
        [TestMethod]
        public void secondLap()
        {
            Assert.AreEqual(4, howManyLapsDoesTheSportman(2, 2));
        }
        

        public int howManyLapsDoesTheSportman(int laps,int rounds)
        {

            laps = rounds;

            int result = laps * rounds;


            return result;
        }

    }

}
