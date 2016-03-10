using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LunchProblem
{
    [TestClass]
    public class Lunch
    {
        [TestMethod]
        public void CalculateCommonDivider()
        {
            Assert.AreEqual(2, CalculateDays(6, 4));
        }
        [TestMethod]
        public void calculateSmallestMultiplier()
        {
            Assert.AreEqual(12, SmallestMultiplier(4, 6)); 
        }

        public int SmallestMultiplier(int firstFriendDays, int secondFriendDays)
        {
            return firstFriendDays * secondFriendDays / CalculateDays(firstFriendDays, secondFriendDays);
        }
        [TestMethod]
        public void CalculateMultiplierAgain()
        {
            Assert.AreEqual(6, SmallestMultiplier(3, 6));
        }

            
        public int CalculateDays(int firstFriendDays,int secondFriendDays)
        {
           
            int  Commondivider = 0;
            while (firstFriendDays!=secondFriendDays)
            {
                if (firstFriendDays > secondFriendDays)
                    return firstFriendDays -= secondFriendDays;
                else return secondFriendDays -= firstFriendDays;

            }

            return Commondivider = firstFriendDays;
        }
        



    }
}
