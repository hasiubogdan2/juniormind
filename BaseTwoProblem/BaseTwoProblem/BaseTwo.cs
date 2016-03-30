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
            CollectionAssert.AreEqual(new byte[] { 0 }, CalculateAND(Convert(1), Convert(2)));
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0 }, CalculateAND(Convert(7), Convert(2)));

        }

        [TestMethod]
        public void GetAtTEst()
        {
            Assert.AreEqual(0, GetAt(0,new byte[] { 3, 2, 0 }));
            Assert.AreEqual(4, GetAt(2, new byte[] { 5, 2, 4, 10, 8 }));
            Assert.AreEqual(7, GetAt(0, new byte[] { 1, 2, 3, 4, 5, 6, 5, 7 }));
            Assert.AreEqual(0, GetAt(10, new byte[] { 2, 3, 4 }));
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
                
                if (GetAt(i, firstBytes) == 1 && GetAt(i, secondBytes) == 1)

                    result[i] = 1;
                else result[i] = 0;
                
                
            }
            return result;
        }

        byte GetAt(int position, byte[] array)
        {
            if (position >= array.Length)
                return 0;
            return array[array.Length - 1 - position];
        }
    }
}
