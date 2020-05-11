using System;
using DSACore.LeetCode;
using DSACore.DataStructures;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[][] {};

            var mss = new FindJudgeSolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(mss.FindJudge(1, input));
            Console.Read();
        }
    }
}
