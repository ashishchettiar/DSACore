using System;
using DSACore.LeetCode;
using DSACore.DataStructures;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[4][];

            board[0] = new char[] { '1','0','1','0','0' };
            board[1] = new char[] { '1','0','1','1','1' };
            board[2] = new char[] { '1','1','1','1','1' };
            board[3] = new char[] { '1','0','0','1','0' };

            var mss = new MaximalSquareSolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(mss.MaximalSquare(board));
            Console.Read();
        }
    }
}
