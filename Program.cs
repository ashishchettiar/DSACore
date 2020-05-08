using System;
using DSACore.LeetCode;
using DSACore.DataStructures;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            CousinsBinaryTreeSolution.TreeNode root = new CousinsBinaryTreeSolution.TreeNode(1);
            root.left = new CousinsBinaryTreeSolution.TreeNode(2);
            root.right = new CousinsBinaryTreeSolution.TreeNode(3);
            root.left.left = new CousinsBinaryTreeSolution.TreeNode(4);

            var mss = new CousinsBinaryTreeSolution();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(mss.IsCousins(root, 4, 3));
            Console.Read();
        }
    }
}
