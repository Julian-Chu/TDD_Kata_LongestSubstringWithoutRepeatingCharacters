using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_Kata_Leetcode_3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LengthOfLongestSubstring_Give_emptystring_Returns_0()
        {
            //Assign
            string target = "";

            //Act
            int actual = LengthOfLongestSubstring(target);
            //Assert
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        private int LengthOfLongestSubstring(string target)
        {
            throw new NotImplementedException();
        }
    }
}
