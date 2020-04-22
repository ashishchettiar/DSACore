using System;
using DSACore.LeetCode;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0,0,0,0,0,0,0,0,0,0 };

            var rotated = new SubarraySumEqualsKSolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(rotated.SubarraySum(nums, 0));
            Console.Read();
        }
    }
}
