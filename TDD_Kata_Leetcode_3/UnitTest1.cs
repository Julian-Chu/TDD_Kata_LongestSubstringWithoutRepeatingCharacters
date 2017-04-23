using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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

        [TestMethod]
        public void LengthOfLongestSubstring_Give_string_a_Returns_1()
        {
            //Assign
            string target = "a";
            //Act
            int actual = LengthOfLongestSubstring(target);
            //Assert
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_Give_string_aa_Return_1()
        {
            //Assign
            string target = "aa";
            //Act
            int actual = LengthOfLongestSubstring(target);
            //Assert
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_Give_string_aba_Return_2()
        {
            //Assign
            string target = "aba";
            //Act
            int actual = LengthOfLongestSubstring(target);
            //Assert
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_Give_string_abb_Return_2()
        {
            //Assign
            string target = "abb";
            //Act
            int actual = LengthOfLongestSubstring(target);
            //Assert
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        private int LengthOfLongestSubstring(string target)
        {
            char[] targetCharArray = target.ToCharArray();
            HashSet<char> substring = new HashSet<char>();
            int maxLength = 0;
            for (int i = 0; i < targetCharArray.Length; i++)
            {
                if (!substring.Add(targetCharArray[i]))
                {
                    maxLength = (maxLength >= substring.Count) ? maxLength : substring.Count;
                }
            }
            maxLength = (maxLength >= substring.Count) ? maxLength : substring.Count;

            return maxLength;
        }
    }
}