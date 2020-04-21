using System;
using DSACore.LeetCode;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5,1,3 };

            var rotated = new SearchRotatedSortedArraySolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(rotated.Search(nums, 5));
            Console.Read();
        }
    }
}
