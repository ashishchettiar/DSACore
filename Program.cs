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
            var ca = new SurroundedRegionsSolution();
            var input = new char[4][];
            input[0] = new char[] {'X','X','X','X'};
            input[1] = new char[] {'X','0','0','X'};
            input[2] = new char[] {'X','X','0','X'};
            input[3] = new char[] {'X','0','X','X'};
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            ca.Solve(input);
            //Console.WriteLine(ca.Solve(input)); // returns true
            Console.Read();
        }
    }
}
