using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
        https://leetcode.com/problems/range-sum-of-bst/
        Given the root node of a binary search tree, return the sum of values of all nodes with a value in the range [low, high].

        Example 1:


        Input: root = [10,5,15,3,7,null,18], low = 7, high = 15
        Output: 32
        Example 2:


        Input: root = [10,5,15,3,7,13,18,1,null,6], low = 6, high = 10
        Output: 23
        

        Constraints:

        The number of nodes in the tree is in the range [1, 2 * 104].
        1 <= Node.val <= 105
        1 <= low <= high <= 105
        All Node.val are unique.
    */
    public class RangeSumBSTSolution {
         public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
    public int RangeSumBST(TreeNode root, int low, int high) {
        int sum = 0;
        if(root == null)
        {
            return sum;
        }
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0)
        {
            var current = queue.Dequeue();
            if(current.val >= low && current.val <= high)
            {
                sum += current.val;
            }
            if(current.left != null && current.val >= low)
            {
                queue.Enqueue(current.left);
            }
            if(current.right != null && current.val <= high)
            {
                queue.Enqueue(current.right);
            }
        }
        
        return sum;
    }
}
}