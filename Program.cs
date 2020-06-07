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
            var ca = new CoinChange2Solution();
            var coins = new int[] {1,2,5};
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(ca.Change(5, coins)); // returns false
            Console.Read();
        }
    }
}
