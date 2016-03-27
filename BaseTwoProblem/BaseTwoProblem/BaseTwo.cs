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
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0 }, Convert(2));
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0 }, Convert(4));
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1 }, Convert(7));
        }

        [TestMethod]
        public void CalculateAND()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0 }, CalculateAND(Convert(1),Convert(2)));
        }
        byte[] Convert(int number)
        {
            int position = 0;
            int remainder = 0;
            byte[] result = new byte[3];
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

        byte[] CalculateAND(byte[] firstBytes,byte[] secondBytes)
        {
            byte[] result = new byte[3];
            for(int i=0; i < firstBytes.Length; i++)
            {
                if (firstBytes[i] == 1 && secondBytes[i] == 1)
                    result[i] = 1;
                else result[i] = 0;
                    
            }
            return result;      
        }


    }
}
