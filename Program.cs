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
            var ca = new SearchInsertPositionSolution();
            var input = new int[] {1,3};
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(ca.SearchInsert(input, 2)); // returns true
            Console.Read();
        }
    }
}
