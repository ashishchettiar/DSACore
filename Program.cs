using System;
using DSACore.LeetCode;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[4][];
            //[["1","1","1","1","0"],["1","1","0","1","0"],["1","1","0","0","0"],["0","0","0","0","0"]]
            board[0] = new char[] { '1', '1', '1', '1', '0' };
            board[1] = new char[] { '1', '1', '0', '1', '0' };
            board[2] = new char[] { '1', '1', '0', '0', '0' };
            board[3] = new char[] { '0', '0', '0', '0', '0' };

            var islands = new NumberOfIslandsSolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(islands.NumIslands(board));
            Console.Read();
        }
    }
}
