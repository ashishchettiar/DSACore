using System;
using DSACore.LeetCode;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] {1,2,3,4};

            var lastStone = new ProductOfArrayExceptSelfSolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(lastStone.ProductExceptSelf(input));
            Console.Read();
        }
    }
}
