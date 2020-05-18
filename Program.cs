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
            var ca = new FindAllAnagramsSolution();
            var input = "cbaebabacd";
            var p = "abc";

            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(ca.FindAnagrams(input, p)); // returns false
            Console.Read();
        }
    }
}
