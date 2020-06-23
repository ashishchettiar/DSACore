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
            var input = new int[] {-19,-46,-19,-46,-9,-9,-19,17,17,17,-13,-13,-9,-13,-46,-28};
            var ca = new SingleNumberIISolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(ca.SingleNumber(input)); // returns true
            Console.Read();
        }
    }
}
