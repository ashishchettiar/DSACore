using System;
using DSACore.LeetCode;
using DSACore.DataStructures;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[5][] {
                    new int[] {-4, -3 },
                    new int[] {1, 0},
                    new int[] {3, -1},
                    new int[] {0, -1},
                    new int[] {-5, 2}
                 };

            var mss = new CheckIfStraightLineSolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(mss.CheckStraightLine(input));
            Console.Read();
        }
    }
}
