using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.LeetCode
{
    //https://leetcode.com/problems/word-search/
    //Given a 2D board and a word, find if the word exists in the grid.

    //The word can be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring.The same letter cell may not be used more than once.

    //Example:

    //board =
    //[
    //  ['A', 'B', 'C', 'E'],
    //  ['S','F','C','S'],
    //  ['A','D','E','E']
    //]

    //Given word = "ABCCED", return true.
    //Given word = "SEE", return true.
    //Given word = "ABCB", return false.

    //Constraints:

    //board and word consists only of lowercase and uppercase English letters.
    //1 <= board.length <= 200
    //1 <= board[i].length <= 200
    //1 <= word.length <= 10^3


    /*WordSearchSolution main

    char[][] board = new char[3][];

    board[0] = new char[] { 'A', 'B', 'C', 'E' };
    board[1] = new char[] { 'S', 'F', 'C', 'S' };
    board[2] = new char[] { 'A', 'D', 'E', 'E' };
            
    var word = "ABCB";

    var wordSearch = new WordSearchSolution();

    Console.WriteLine(wordSearch.Exist(board, word));
    */
    public class WordSearchSolution
    {
        public bool Exist(char[][] board, string word)
        {
            var numberOfRows = board.Length;
            var numberOfColumns = board[0].Length;

            //covert word to char array
            var wordArray = word.ToCharArray();

            var result = false;
            for(int row = 0; row < numberOfRows; row++)
            {
                for (int column = 0; column < numberOfColumns; column++)
                {
                    bool[,] visited = new bool[numberOfRows, numberOfColumns];
                    result = TraverseBoard(board, wordArray, row, column, 0, visited);
                    if (result) return result;
                }
            }

            return result;
        }

        private bool TraverseBoard(char[][] board, char[] word, int row, int column, int wordPosition, bool[,] visited)
        {
            var numberOfRows = board.Length;
            var numberOfColumns = board[0].Length;

            if ((row < 0 || column < 0) || (row >= numberOfRows || column >= numberOfColumns) || visited[row, column])
                return false;

            visited[row, column] = true;

            if (board[row][column] == word[wordPosition])
            {
                if (wordPosition == word.Length - 1)
                {
                    return true;
                }
                else if (TraverseBoard(board, word, row, column + 1, wordPosition + 1, visited) ||
                    TraverseBoard(board, word, row, column - 1, wordPosition + 1, visited) ||
                    TraverseBoard(board, word, row + 1, column, wordPosition + 1, visited) ||
                    TraverseBoard(board, word, row - 1, column, wordPosition + 1, visited))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
