using System;
using DSACore.LeetCode;
using DSACore.DataStructures;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 2,3,1,1,4 };
            var game = new JumpGameSolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(game.CanJump(input));
            Console.Read();
        }
    }
}
