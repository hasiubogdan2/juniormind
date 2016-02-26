﻿using System;
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
        public void Buzztest()
        {
            Assert.AreEqual("Buzz", CalculateFizzBuzz(5));
        }
        [TestMethod]
        public void FizzBuzzTest()
        {
            Assert.AreEqual("FizzBuzz", CalculateFizzBuzz(15));
        }

        public string CalculateFizzBuzz(int multiplier)
        {
            string problemString = "";

            if (multiplier % 3 == 0)  problemString= "Fizz";

            if (multiplier % 5 == 0)  problemString= "Buzz";

            if ((multiplier%3==0)&&(multiplier%5==0)) problemString = "FizzBuzz";

            return problemString;
        }

            
        } 
    }


