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
            var ca = new OddEvenLinkedListSolution();
            var input = new OddEvenLinkedListSolution.ListNode(1);
            input.next = new OddEvenLinkedListSolution.ListNode(2);
            input.next.next = new OddEvenLinkedListSolution.ListNode(3);
            input.next.next.next = new OddEvenLinkedListSolution.ListNode(4);
            input.next.next.next = new OddEvenLinkedListSolution.ListNode(5);

            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(ca.OddEvenList(input)); // returns false
            Console.Read();
        }
    }
}
