using System;
using DSACore.LeetCode;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            var stones = new int[] {2, 7, 4, 1, 8, 1};;
            var lastStone = new LastStoneWeightSolution();
            Console.WriteLine("Pause to attach debugger");
            Console.WriteLine(lastStone.LastStoneWeight(stones));
            Console.Read();
        }
    }
}
