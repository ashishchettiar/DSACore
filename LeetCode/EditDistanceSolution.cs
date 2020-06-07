using System;
using System.Text;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/edit-distance/
    Given two words word1 and word2, find the minimum number of operations required to convert word1 to word2.

    You have the following 3 operations permitted on a word:

    Insert a character
    Delete a character
    Replace a character
    Example 1:

    Input: word1 = "horse", word2 = "ros"
    Output: 3
    Explanation: 
    horse -> rorse (replace 'h' with 'r')
    rorse -> rose (remove 'r')
    rose -> ros (remove 'e')
    Example 2:

    Input: word1 = "intention", word2 = "execution"
    Output: 5
    Explanation: 
    intention -> inention (remove 't')
    inention -> enention (replace 'i' with 'e')
    enention -> exention (replace 'n' with 'x')
    exention -> exection (replace 'n' with 'c')
    exection -> execution (insert 'u')
    */
    public class EditDistanceSolution
    {
        public int MinDistance(string word1, string word2)
        {
            var dp = new int[word2.Length + 1, word1.Length + 1];

            for (int row = 0; row <= word2.Length; row++)
            {
                for (int col = 0; col <= word1.Length; col++)
                {
                    if(row == 0) dp[row, col] = col;
                    else if(col == 0) dp[row, col] = row;
                    else if (word2[row - 1] != word1[col - 1])
                    {
                        dp[row, col] = Math.Min(dp[row, col - 1], Math.Min(dp[row - 1, col], dp[row - 1, col - 1])) + 1;
                    }
                    else
                    {
                        dp[row, col] = dp[row - 1, col - 1];
                    }
                }
            }

            return dp[word2.Length, word1.Length];
        }
    }
}