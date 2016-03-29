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
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, Convert(2));
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0 }, Convert(4));
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1 }, Convert(7));
        }

        [TestMethod]
        public void CalculateAND()
        {
            CollectionAssert.AreEqual(Convert(1 & 2), CalculateAND(Convert(1), Convert(2)));
            CollectionAssert.AreEqual(Convert(7 & 2), CalculateAND(Convert(7), Convert(2)));
        }

        [TestMethod]
        public void GetAtTEst()
        {
            Assert.AreEqual(new byte[] { 0 }, GetAt(2,new byte[] { 3, 2, 0 }));
        }
        byte[] Convert(int number)
        {

            int remainder = 0;
            byte[] result = new byte[0];
            while (number != 0)
            {
                remainder = number % 2;
                number /= 2;
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = (byte)remainder;

            }
            Array.Reverse(result);
            return result;

        }

        byte[] CalculateAND(byte[] firstBytes, byte[] secondBytes)
        {
            byte[] result = new byte[firstBytes.Length];
            for (int i = 0; i < firstBytes.Length; i++)
            {
                if (firstBytes[i] == 1 && secondBytes[i] == 1)
                    result[i] = 1;
                else result[i] = 0;


            }
            return result;
        }

        byte GetAt(int position, byte[] length)
        {
            if (position > length.Length - 1)
                return 0;
            return length[length.Length - 1 - position];
        }
    }
}
