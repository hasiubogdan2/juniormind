using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzProblem
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void Fizztest()
        {
            Assert.AreEqual("Fizz", CalculateFizzBuzz(3));
        }

        [TestMethod]
        public void BuzzTest()
        {
            Assert.AreEqual("Buzz", CalculateFizzBuzz(5));
        }
    
        public string CalculateFizzBuzz(int multiplier)
        {
            if ((multiplier > 2) && (multiplier % 3 == 0))
            {
                return "Fizz";
            }
            else return "This is not Fizz";

            if ((multiplier > 4) && (multiplier % 5 == 0))
            {
                return "Buzz";
            }
            else return "This is not a Buzz";
            
        }

    }
}
