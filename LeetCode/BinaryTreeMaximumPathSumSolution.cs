using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/binary-tree-maximum-path-sum/
    Given a non-empty binary tree, find the maximum path sum.

    For this problem, a path is defined as any sequence of nodes from some starting node to any node in the tree along the parent-child connections. The path must contain at least one node and does not need to go through the root.

    Example 1:

    Input: [1,2,3]

         1
        / \
        2   3

    Output: 6
    Example 2:

    Input: [-10,9,20,null,null,15,7]

    -10
    / \
    9   20
        /  \
       15   7

    Output: 42
    */

    /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
    public class BinaryTreeMaximumPathSumSolution
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        int maxSum  = Int32.MinValue;
        public int MaxPathSum(TreeNode root)
        {
            PathSum(root);
            return maxSum;
        }

        private int PathSum(TreeNode node)
        {
            if(node == null) return 0;
            var left = Math.Max(0, PathSum(node.left));
            var right = Math.Max(0, PathSum(node.right));
            maxSum = Math.Max(maxSum, left + right + node.val); 
            return Math.Max(left, right) + node.val;
        }
    }
}