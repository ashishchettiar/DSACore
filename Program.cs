using System;
using DSACore.LeetCode;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitwise = new BitwiseANDofNumbersRangeSolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(bitwise.RangeBitwiseAnd(5, 7));
            Console.Read();
        }
    }
}
