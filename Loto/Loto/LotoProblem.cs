using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    [TestClass]
    public class LotoProblem
    {
        [TestMethod]
        public void Factorial()
        {
            Assert.AreEqual(6, Factorial(3));
        }
        [TestMethod]
        public void CalculateCombinations()
        {
            Assert.AreEqual(6,CalculateCombinations(4,2));
        }
        [TestMethod]
        public void CalculateLotoCategory1()
        {
            Assert.AreEqual(0.0000000715, CalculateLotoChances(6,6,49));
        }
        public double CalculateLotoChances(int favorableCases, int posibleCases, int totalNumbers)
        {
            double chances = ((CalculateCombinations(posibleCases, favorableCases) * CalculateCombinations((totalNumbers - posibleCases), (posibleCases - favorableCases))) / CalculateCombinations(totalNumbers, posibleCases));
            return chances;
        }
        public double Factorial(int number)
        {
            double result = 1;
            while (number != 0)
            {
                result *= number;
                number--;
            }
            return result;
        }

        public double CalculateCombinations(int n, int k)
        {
            if (n>k)

                return Factorial(n) / (Factorial(k) * Factorial(n - k));

            return 0;
        }

    }
}
