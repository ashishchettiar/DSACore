using System;
using System.Linq;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/surrounded-regions/
    Given a 2D board containing 'X' and 'O' (the letter O), capture all regions surrounded by 'X'.

    A region is captured by flipping all 'O's into 'X's in that surrounded region.

    Example:

    X X X X
    X O O X
    X X O X
    X O X X
    After running your function, the board should be:

    X X X X
    X X X X
    X X X X
    X O X X
    Explanation:

    Surrounded regions shouldn’t be on the border, which means that any 'O' on the border of the board are not flipped to 'X'. Any 'O' that is not on the border and it is not connected to an 'O' on the border will be flipped to 'X'. Two cells are connected if they are adjacent cells connected horizontally or vertically.
    */
    public class SurroundedRegionsSolution
    {
        public void Solve(char[][] board)
        {
            if (board.Length == 0 || board[0].Length == 0) return;

            var rows = board.Length;
            var columns = board[0].Length;

            //mark '0' at the edges as *
            for (int row = 0; row < rows; row++)
            {
                if(board[row][0] == '0') MarkBoundaryToStar(board, row, 0);
                if(board[row][columns - 1] == '0') MarkBoundaryToStar(board, row, columns - 1);
            }

            for (int col = 0; col < columns; col++)
            {
                if(board[0][col] == '0') MarkBoundaryToStar(board, 0, col);
                if(board[rows - 1][col] == '0') MarkBoundaryToStar(board, rows-1, col);
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if(board[row][col] == '0')
                    {
                        board[row][col] = 'X';
                    }
                    else if(board[row][col] == '*')
                    {
                        board[row][col] = '0';
                    }
                }
            }
        }

        private void MarkBoundaryToStar(char[][] board, int row, int col)
        {
            if(row > board.Length -1 || col > board[0].Length -1 || row < 0 || col < 0) return;

            if(board[row][col] == '0') board[row][col] = '*';

            if(row > 0 && board[row-1][col] == '0') MarkBoundaryToStar(board, row-1, col);
            if(row < board.Length -1 && board[row + 1][col] == '0') MarkBoundaryToStar(board, row+1, col);
            if(col > 0 && board[row][col-1] == '0') MarkBoundaryToStar(board, row, col-1);
            if(col < board[0].Length -1 && board[row][col+1] == '0') MarkBoundaryToStar(board, row, col+1);

            return;
        }
    }
}