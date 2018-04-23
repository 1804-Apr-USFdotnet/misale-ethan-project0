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
            string check = "1221";

            PalindromeCheck(check);

            
        }
    }
}
