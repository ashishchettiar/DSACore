using System;
using DSACore.LeetCode;
using DSACore.DataStructures;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            int []arr = {0,1,0,1};  // [0,1,0,0,1,0,null,null,1,0,0]
            ValidSequenceFromRootToLeaves.TreeNode root= new ValidSequenceFromRootToLeaves.TreeNode(0); 
            root.left=new ValidSequenceFromRootToLeaves.TreeNode(1); 
            root.right=new ValidSequenceFromRootToLeaves.TreeNode(0); 
            root.left.left = new ValidSequenceFromRootToLeaves.TreeNode(0);  
            root.left.right = new ValidSequenceFromRootToLeaves.TreeNode(1);  
            root.left.left.left = null;
            root.left.left.right = new ValidSequenceFromRootToLeaves.TreeNode(1);  
            root.left.right.left = new ValidSequenceFromRootToLeaves.TreeNode(0);
            root.left.right.right = new ValidSequenceFromRootToLeaves.TreeNode(0);
            root.right.left =new ValidSequenceFromRootToLeaves.TreeNode(0); 
            root.right.right =null; 

            var mss = new ValidSequenceFromRootToLeaves();
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            Console.WriteLine(mss.IsValidSequence(root, arr));
            Console.Read();
        }
    }
}
