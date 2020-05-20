using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/kth-smallest-element-in-a-bst/
    Given a binary search tree, write a function kthSmallest to find the kth smallest element in it.

    Note:
    You may assume k is always valid, 1 ≤ k ≤ BST's total elements.

    Example 1:

    Input: root = [3,1,4,null,2], k = 1
    3
    / \
    1   4
    \
    2
    Output: 1
    Example 2:

    Input: root = [5,3,6,2,4,null,null,1], k = 3
        5
        / \
        3   6
        / \
    2   4
    /
    1
    Output: 3
    Follow up:
    What if the BST is modified (insert/delete operations) often and you need to find the kth smallest frequently? How would you optimize the kthSmallest routine?
    */
    public class KthSmallestElementInBSTSolution
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

        List<int> inOrder = new List<int>();

        public int KthSmallest(TreeNode root, int k)
        {
            TraverseInorder(root);
            return inOrder[k - 1];
        }

        private void TraverseInorder(TreeNode node)
        {
            if (node == null)
                return;

            /* first recur on left child */
            TraverseInorder(node.left);

            inOrder.Add(node.val);

            /* now recur on right child */
            TraverseInorder(node.right);
        }
    }
}