﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PanagramProblem
{
    [TestClass]
    public class Panagram
    {
        [TestMethod]
        public void CalculateIfPanagram()
        {
            Assert.AreEqual(false, FindIfPanagram("b     c"));

        }
        [TestMethod]
        public void CalculateIfPanagramSentence()
        {
            Assert.AreEqual(true, FindIfPanagram("The quick brown fox jumps over the lazy dog"));

        }
        [TestMethod]
        public void CalculateIfPanagramLetters()
        {
            Assert.AreEqual(true, FindIfPanagram("abcdefghijklmnopqrstuvwxyz"));
        }
        [TestMethod]
        public void CalculatePanagram()
        {
            Assert.AreEqual(false, FindIfPanagram("We love coding"));
        }
        [TestMethod]
        public void CalculateIfPanagram3()
        {
            Assert.AreEqual(true, FindIfPanagram("zyxwvutsrqponmlkjihgfedcba"));
        }
        public bool FindIfPanagram(string sentence)
        {
            string lowerCaseTransform = sentence.ToLower();
            if (CheckIfPanagram(lowerCaseTransform))
                return true;
            else return false;
        }
        [TestMethod]
        public void MyTestMethod()
        {
            Assert.IsFalse(FindIfPanagram(new string('a', 26)));

        }
        public bool CheckIfPanagram(string panagram)
        {
            
            for (int j = 'a'; j < 'z';j++)

            {
                int count = 0;

                for (int i = 0; i < panagram.Length; i++)
                {
                    if (panagram[i] == j) count++;
                }
                    if (count == 0) return false;
                
            }
            
            return true;

        }

    }
}

