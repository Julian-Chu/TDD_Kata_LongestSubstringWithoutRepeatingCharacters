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
        public void LengthOfLongestSubstring_Give_string_ab_Return_2()
        {
            //Assign
            string target = "ab";
            //Act
            int actual = LengthOfLongestSubstring(target);
            //Assert
            int expected = 2;
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


        [TestMethod]
        public void LengthOfLongestSubstring_Give_string_abcda_Return_4()
        {
            //Assign
            string target = "abcda";
            //Act
            int actual = LengthOfLongestSubstring(target);
            //Assert
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_Give_string_pwwkew_Return_3()
        {
            //Assign
            string target = "pwwkew";
            //Act
            int actual = LengthOfLongestSubstring(target);
            //Assert
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_Give_string_abcabcbb_Return_3()
        {
            //Assign
            string target = "abcabcbb";
            //Act
            int actual = LengthOfLongestSubstring(target);
            //Assert
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void LengthOfLongestSubstring_Give_string_nfpdmpi_Return_5()
        {
            //Assign
            string target = "nfpdmpi";
            //Act
            int actual = LengthOfLongestSubstring(target);
            //Assert
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }

        private int LengthOfLongestSubstring(string s)
        {
            if (s == "") return 0;
            char[] targetCharArray = s.ToCharArray();
            int substringHead = 0;
            int maxLength = targetCharArray.Length == 1 ? 1 : 0;
            Dictionary<char, int> substring = new Dictionary<char, int>();
            substring.Add(targetCharArray[0], 0);

            for (int i = 1; i < targetCharArray.Length; i++)
            {
                if (substring.ContainsKey(targetCharArray[i]))
                {
                    maxLength = maxLength > i - substringHead ? maxLength : i - substringHead;
                    substringHead = substring[targetCharArray[i]] + 1;
                    substring[targetCharArray[i]] = i;
                }
                else
                {
                    substring.Add(targetCharArray[i], i);
                    maxLength = i - substringHead + 1;
                }
            }

            return maxLength;
        }
    }
}