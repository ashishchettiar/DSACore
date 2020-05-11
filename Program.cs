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
            var input = new int[3][];
            input[0] = new int[] { 1, 1, 1 };
            input[1] = new int[] { 1, 1, 0 };
            input[2] = new int[] { 1, 0, 1 };

            var mss = new FloodFill();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            //Console.WriteLine(mss.Fill(input, 1, 1));
            mss.Fill(input, 1, 1, 2);
            Console.Read();
        }
    }
}
