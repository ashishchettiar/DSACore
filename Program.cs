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
            var input = new int[] {1,1,2};

            var mss = new SingleElementSortedArraySolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(mss.SingleNonDuplicate(input));
            Console.Read();
        }
    }
}
