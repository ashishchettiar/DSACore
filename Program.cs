using System;
using DSACore.LeetCode;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[3][];

            board[0] = new char[] { 'A', 'B', 'C', 'E' };
            board[1] = new char[] { 'S', 'F', 'C', 'S' };
            board[2] = new char[] { 'A', 'D', 'E', 'E' };
                    
            var word = "ABCB";

            var wordSearch = new WordSearchSolution();

            Console.WriteLine(wordSearch.Exist(board, word));
            Console.Read();
        }
    }
}
