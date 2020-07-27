using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/perfect-squares/
    Given a positive integer n, find the least number of perfect square numbers (for example, 1, 4, 9, 16, ...) which sum to n.

    Example 1:

    Input: n = 12
    Output: 3 
    Explanation: 12 = 4 + 4 + 4.
    Example 2:

    Input: n = 13
    Output: 2
    Explanation: 13 = 4 + 9.
    */
    public class PerfectSquaresSolution
    {
        public int NumSquares(int n)
        {
            int[] dp = new int[n + 1];
            for(int i=0; i<n+1;i++)
            {
                dp[i] = Int32.MaxValue;
            }

            // bottom case
            dp[0] = 0;

            // pre-calculate the square numbers.
            int max_square_index = (int)Math.Sqrt(n) + 1;
            int[] square_nums = new int[max_square_index];
            for (int i = 1; i < max_square_index; ++i)
            {
                square_nums[i] = i * i;
            }

            for (int i = 1; i <= n; ++i)
            {
                for (int s = 1; s < max_square_index; ++s)
                {
                    if (i < square_nums[s])
                        break;
                    dp[i] = Math.Min(dp[i], dp[i - square_nums[s]] + 1);
                }
            }
            return dp[n];
        }
    }
}