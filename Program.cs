using System;
using DSACore.LeetCode;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "(";

            var lastStone = new ValidParenthesisStringSolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(lastStone.CheckValidString(input));
            Console.Read();
        }
    }
}
