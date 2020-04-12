using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class DiameterOfBinaryTreeSolution
    {
        int diameter = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            GetDiameter(root);
            return diameter;
        }

        private void GetDiameter(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            int left = GetHeight(node.left);
            int right = GetHeight(node.right);

            diameter = Math.Max(left + right, diameter);

            GetDiameter(node.left);
            GetDiameter(node.right);

            return;
        }

        private int GetHeight(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int left = GetHeight(node.left);
            int right = GetHeight(node.right);

            return Math.Max(left, right) + 1;
        }
    }
}