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
            var ca = new MaximumSumCircularSubarraySolution();
            var input = new int[] {-3,-2,-1};

            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(ca.MaxSubarraySumCircular(input)); // returns false
            Console.Read();
        }
    }
}
