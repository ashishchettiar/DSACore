using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/maximal-square/
    Given a 2D binary matrix filled with 0's and 1's, find the largest square containing only 1's and return its area.

    Example:

    Input: 

    1 0 1 0 0
    1 0 1 1 1
    1 1 1 1 1
    1 0 0 1 0

    Output: 4
    */
    public class MaximalSquareSolution
    {
        public int MaximalSquare(char[][] matrix)
        {
            var max = 0;
            
            if(matrix == null || matrix.Length == 0) return 0;
            
            var dp = new int[matrix.Length + 1, matrix[0].Length + 1];

            for (int row = 0; row < matrix.Length + 1; row++)
            {
                for (int col = 0; col < matrix[0].Length + 1; col++)
                {
                    if (row == 0 || col == 0)
                    {
                        dp[row, col] = 0;
                    }
                    else
                    {
                        if (matrix[row - 1][col - 1] == '1')
                        {
                            dp[row, col] = Math.Min(Math.Min(dp[row - 1, col], dp[row, col - 1]), dp[row - 1, col - 1]) + 1;
                            max = Math.Max(max, dp[row, col]);
                        }
                        else
                        {
                            dp[row, col] = 0;
                        }
                    }
                }
            }

            return max*max;
        }
    }
}