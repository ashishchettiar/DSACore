using System;
using DSACore.LeetCode;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[3][];
            input[0] = new int[] {1, 1};
            input[0] = new int[] {1, 1};
            input[0] = new int[] {0, 2};
            input[0] = new int[] {1, 3};

            var lastStone = new PerformStringShiftsSolution();
            Console.WriteLine("Pause to attach debugger");
            Console.WriteLine(lastStone.StringShift("qwerty", input));
            Console.Read();
        }
    }
}
