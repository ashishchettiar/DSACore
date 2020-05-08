using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/cousins-in-binary-tree/
    In a binary tree, the root node is at depth 0, and children of each depth k node are at depth k+1.

    Two nodes of a binary tree are cousins if they have the same depth, but have different parents.

    We are given the root of a binary tree with unique values, and the values x and y of two different nodes in the tree.

    Return true if and only if the nodes corresponding to the values x and y are cousins.

    

    Example 1:


    Input: root = [1,2,3,4], x = 4, y = 3
    Output: false
    Example 2:


    Input: root = [1,2,3,null,4,null,5], x = 5, y = 4
    Output: true
    Example 3:



    Input: root = [1,2,3,null,4], x = 2, y = 3
    Output: false
    */
    public class CousinsBinaryTreeSolution
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

        TreeNode Parent;
        
        public bool IsCousins(TreeNode root, int x, int y)
        {
            TreeNode ParentOfX = null;
            int DepthOfX = 0;
            TreeNode ParentOfY = null;
            int DepthOfY = 0;

            DepthOfX = GetHeight(root, x, 0);
            ParentOfX = Parent;
            Parent = null;
            DepthOfY = GetHeight(root, y, 0);
            ParentOfY = Parent;

            if (DepthOfX == DepthOfY && ParentOfX != ParentOfY) return true;
            else return false;
        }

        private int GetHeight(TreeNode node, int valueToFind, int depth)
        {
            if (node == null) return 0;

            if (node.val == valueToFind)
            {
                return depth;
            }

            Parent = node;
            var left = GetHeight(node.left, valueToFind, depth + 1);
            if(left != 0) return left;
            
            Parent = node;
            var right = GetHeight(node.right, valueToFind, depth + 1);
            return right;
        }
    }
}
