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

        

        public string CalculateFizzBuzz(int multiplier)
        {
            string problemString = "";
            if (multiplier % 3 == 0)
            {
                return "Fizz";
            }
            else
                return "THis is not a Fizz";

            
        } 
    }
}

