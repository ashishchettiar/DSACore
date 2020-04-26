using System;
using DSACore.LeetCode;
using DSACore.DataStructures;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = "abcde";
            var t2 = "ace";
            var lcs = new LongestCommonSubsequenceSolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(lcs.LongestCommonSubsequence(t1, t2));
            Console.Read();
        }
    }
}
