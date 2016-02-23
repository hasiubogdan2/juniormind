using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportManProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void firstLap()
        { Assert.AreEqual(1,howManyLapsDoesTheSportman(1));

}
        [TestMethod]
        public void secondLap()
        {
            Assert.AreEqual(4, howManyLapsDoesTheSportman(2));
        }
        

        public int howManyLapsDoesTheSportman(int rounds)
        {

           int result = rounds*rounds;

            


            return result;
        }

    }

}
