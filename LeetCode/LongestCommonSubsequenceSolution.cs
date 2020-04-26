using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/longest-common-subsequence/
    Given two strings text1 and text2, return the length of their longest common subsequence.

    A subsequence of a string is a new string generated from the original string with some characters(can be none) deleted without changing the relative order of the remaining characters. (eg, "ace" is a subsequence of "abcde" while "aec" is not). A common subsequence of two strings is a subsequence that is common to both strings.

    If there is no common subsequence, return 0.

    Example 1:

    Input: text1 = "abcde", text2 = "ace" 
    Output: 3  
    Explanation: The longest common subsequence is "ace" and its length is 3.
    Example 2:

    Input: text1 = "abc", text2 = "abc"
    Output: 3
    Explanation: The longest common subsequence is "abc" and its length is 3.
    Example 3:

    Input: text1 = "abc", text2 = "def"
    Output: 0
    Explanation: There is no such common subsequence, so the result is 0.
    

    Constraints:

    1 <= text1.length <= 1000
    1 <= text2.length <= 1000
    The input strings consist of lowercase English characters only.

    Approch 3 implemented from https://leetcode.com/problems/longest-common-subsequence/solution/
    */
    public class LongestCommonSubsequenceSolution
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            var rowArray = text1.ToCharArray();
            var colArray = text2.ToCharArray();
            var dp = new int[rowArray.Length + 1, colArray.Length + 1];

            for (int i = colArray.Length; i >= 0; i--)
            {
                for (int j = rowArray.Length; j >= 0; j--)
                {
                    if (i > colArray.Length - 1 || j > rowArray.Length - 1)
                    {
                        dp[j, i] = 0;
                    }
                    else
                    {
                        if (colArray[i] == rowArray[j])
                        {
                            var prev = dp[j + 1, i +1];
                            dp[j, i] = prev + 1;
                        }
                        else
                        {
                            var prevCol = dp[j + 1, i];
                            var preRow = dp[j, i + 1];
                            dp[j, i] = Math.Max(prevCol, preRow);
                        }
                    }
                }
            }

            return dp[0, 0];
        }
    }
}