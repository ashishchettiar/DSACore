﻿using System;
using DSACore.LeetCode;
using DSACore.DataStructures;
using DSACore.Algorithms;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            var ca = new IsSubsequenceSolution();

            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(ca.IsSubsequence("","abc")); // returns true
            Console.Read();
        }
    }
}
