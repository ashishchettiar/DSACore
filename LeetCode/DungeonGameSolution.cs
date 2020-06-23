using System;
using System.Linq;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/dungeon-game/
    The demons had captured the princess (P) and imprisoned her in the bottom-right corner of a dungeon. The dungeon consists of M x N rooms laid out in a 2D grid. Our valiant knight (K) was initially positioned in the top-left room and must fight his way through the dungeon to rescue the princess.

    The knight has an initial health point represented by a positive integer. If at any point his health point drops to 0 or below, he dies immediately.

    Some of the rooms are guarded by demons, so the knight loses health (negative integers) upon entering these rooms; other rooms are either empty (0's) or contain magic orbs that increase the knight's health (positive integers).

    In order to reach the princess as quickly as possible, the knight decides to move only rightward or downward in each step.

    

    Write a function to determine the knight's minimum initial health so that he is able to rescue the princess.

    For example, given the dungeon below, the initial health of the knight must be at least 7 if he follows the optimal path RIGHT-> RIGHT -> DOWN -> DOWN.

    -2 (K)	-3	3
    -5	-10	1
    10	30	-5 (P)
    

    Note:

    The knight's health has no upper bound.
    Any room can contain threats or power-ups, even the first room the knight enters and the bottom-right room where the princess is imprisoned.
    */
    public class DungeonGameSolution
    {
        int inf = Int32.MaxValue;
        int[,] dp;
        int rows, cols;

        public int getMinHealth(int currCell, int nextRow, int nextCol)
        {
            if (nextRow >= this.rows || nextCol >= this.cols)
                return inf;
            int nextCell = this.dp[nextRow, nextCol];
            // hero needs at least 1 point to survive
            return Math.Max(1, nextCell - currCell);
        }
        
        public int CalculateMinimumHP(int[][] dungeon)
        {
            this.rows = dungeon.Length;
            this.cols = dungeon[0].Length;
            this.dp = new int[rows,cols];
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < cols; column++)
                {
                    this.dp[row, column] = this.inf;
                }
            }

            int currCell, rightHealth, downHealth, nextHealth, minHealth;
            for (int row = this.rows - 1; row >= 0; --row)
            {
                for (int col = this.cols - 1; col >= 0; --col)
                {
                    currCell = dungeon[row][col];

                    rightHealth = getMinHealth(currCell, row, col + 1);
                    downHealth = getMinHealth(currCell, row + 1, col);
                    nextHealth = Math.Min(rightHealth, downHealth);

                    if (nextHealth != inf)
                    {
                        minHealth = nextHealth;
                    }
                    else
                    {
                        minHealth = currCell >= 0 ? 1 : 1 - currCell;
                    }
                    this.dp[row, col] = minHealth;
                }
            }
            return this.dp[0,0];
        }
    }
}