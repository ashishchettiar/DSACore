using System;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/minimum-path-sum/
    Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right which minimizes the sum of all numbers along its path.

    Note: You can only move either down or right at any point in time.

    Example:

    Input:
    [
    [1,3,1],
    [1,5,1],
    [4,2,1]
    ]
    Output: 7
    Explanation: Because the path 1→3→1→1→1 minimizes the sum.
    */
    public class MinimumPathSumSolution
    {
        public int MinPathSum(int[][] grid)
        {
            if (grid == null || grid.Length == 0) return 0;

            int[,] dp = new int[grid.Length, grid[0].Length];

            for(int row = 0; row < grid.Length; row++)
            {
                for(int column = 0; column < grid[0].Length; column++)
                {
                    dp[row, column] = grid[row][column];
                    if(row > 0 && column > 0)
                    {
                        dp[row, column] += Math.Min(dp[row -1, column], dp[row, column-1]);
                    }
                    
                    if(row > 0 && column == 0)
                    {
                        dp[row, column] += dp[row -1, column];
                    }
                    
                    if(column > 0 && row == 0)
                    {
                        dp[row, column] += dp[row, column-1];
                    }
                }
            }

            return dp[grid.Length - 1, grid[0].Length -1];
        }
    }
}