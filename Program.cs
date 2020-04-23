using System;
using DSACore.LeetCode;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1,2,0 };
            var sc = new SortColorsSolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            sc.SortColors(nums);
            Console.WriteLine();
            Console.Read();
        }
    }
}
