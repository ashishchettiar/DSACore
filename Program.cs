using System;
using DSACore.LeetCode;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] board = new int[3][];
            //[["1","1","1","1","0"],["1","1","0","1","0"],["1","1","0","0","0"],["0","0","0","0","0"]]
            board[0] = new int[] { 1,3,1 };
            board[1] = new int[] { 1,5,1 };
            board[2] = new int[] { 4,2,1 };

            var islands = new MinimumPathSumSolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(islands.MinPathSum(board));
            Console.Read();
        }
    }
}
