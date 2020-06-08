using System;
using DSACore.LeetCode;
using DSACore.DataStructures;
using DSACore.Algorithms;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            var ca = new QueueReconstructionByHeightSolution();
            //[[7,0], [4,4], [7,1], [5,0], [6,1], [5,2]]
            var coins = new int[6][];
            coins[0] = new int[] {7,0};
            coins[1] = new int[] {4,4};
            coins[2] = new int[] {7,1};
            coins[3] = new int[] {5,0};
            coins[4] = new int[] {6,1};
            coins[5] = new int[] {5,2};

            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(ca.ReconstructQueue(coins)); // returns false
            Console.Read();
        }
    }
}
