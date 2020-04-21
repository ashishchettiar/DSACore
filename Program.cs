using System;
using DSACore.LeetCode;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4,2 };

            var rotated = new BinarySearchTreeFromPreorderSolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(rotated.BstFromPreorder(nums));
            Console.Read();
        }
    }
}
