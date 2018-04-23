using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;



namespace PalindromeTest
{
    [TestClass]
    public class PalindromeCheckTest

    {
        [TestMethod]
        public void PalindromeCheckerTest()
        {
            string check = "RaceCar";
            bool expected = true;

            bool actual = PalindromeCheck.PalindromeChecker(check);

            Assert.AreEqual(expected, actual);

            
        }
        [TestMethod]
        public void PalindromeCheckerTest1()
        {
            string check = "1221";
            bool expected = true;

            bool actual = PalindromeCheck.PalindromeChecker(check);

            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void PalindromeCheckerTest2()
        {
            string check = "never odd, or even.";
            bool expected = true;

            bool actual = PalindromeCheck.PalindromeChecker(check);

            Assert.AreEqual(expected, actual);


        }
    }
}
