using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/number-of-islands/
    Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

    Example 1:

    Input:
    11110
    11010
    11000
    00000

    Output: 1
    Example 2:

    Input:
    11000
    11000
    00100
    00011

    Output: 3

    Program.cs
    char[][] board = new char[4][];

    board[0] = new char[] { '1', '1', '0', '0', '0' };
    board[1] = new char[] { '1', '1', '0', '0', '0' };
    board[2] = new char[] { '0', '0', '1', '0', '0' };
    board[3] = new char[] { '0', '0', '0', '1', '1' };
            
    var islands = new NumberOfIslandsSolution();

    Console.WriteLine(islands.NumIslands(board));
    */
    public class NumberOfIslandsSolution
    {
        public int NumIslands(char[][] grid)
        {
            if(grid.Length == 0) return 0;

            var islandsCount = 0;
            var rowsCount = grid.Length;
            var colsCount = grid[0].Length;
            if(rowsCount == 0 && colsCount == 0) return 0;

            bool[,] visited = new bool[rowsCount, colsCount];

            for(int row = 0; row < rowsCount; row++)
            {
                for(int col = 0; col < colsCount; col++)
                {
                    if(!visited[row, col] && grid[row][col] == '1')
                    {
                        FindIsland(row, col, grid, visited);
                        islandsCount++;
                    }
                }
            }

            return islandsCount;
        }

        private void FindIsland(int row, int col, char[][] grid, bool[,] visited)
        {
            var numberOfRows = grid.Length;
            var numberOfColumns = grid[0].Length;

            if((row < 0 || col < 0) || (row >= numberOfRows || col >= numberOfColumns) || grid[row][col] == '0' || visited[row, col]) return;

            visited[row, col] = true;

            FindIsland(row + 1, col, grid, visited);
            FindIsland(row - 1, col, grid, visited);
            FindIsland(row, col + 1, grid, visited);
            FindIsland(row, col - 1, grid, visited);

            return;
        }
    }
}