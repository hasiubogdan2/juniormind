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
            Assert.AreEqual(6,CalculateCombinationsOfNtakenByK(4,2));

        }
        public double CalculateLotoChances(int posibleCases,int favorableCases)
        {
            posibleCases = 49;
            favorableCases = 6;

            return 0;
        }
        public double Factorial(int number)
        {
            int result = 1;
            while (number != 0)
            {
                result *= number;
                number--;
            }
            return result;
        }

        public double CalculateCombinationsOfNtakenByK(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));


        }

    }
}
