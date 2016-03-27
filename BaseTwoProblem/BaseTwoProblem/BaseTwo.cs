using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseTwoProblem
{
    [TestClass]
    public class BaseTwo
    {
        [TestMethod]
        public void ConvertInBaseTwo()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0 }, ConvertInBaseTwo(2));
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0 }, ConvertInBaseTwo(4));
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1 }, ConvertInBaseTwo(7));



        }
        byte[] ConvertInBaseTwo(int number)
        {
            int position = 0;
            int remainder = 0;
            byte[] result = {0,0,0 };
            while (number != 0)
            {
                remainder = number % 2;
                number /= 2;
                result[position] = (byte)remainder;
                position++;
            }
            Array.Reverse(result);
            return result;

        }
    }
}
