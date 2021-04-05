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
            var ca = new QueueUsingStacksSolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            ca.Push(1);
            ca.Push(2);
            ca.Peek();
            Console.Read();
        }
    }
}
