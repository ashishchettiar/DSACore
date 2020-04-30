using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    Given a binary tree where each path going from the root to any leaf form a valid sequence, check if a given string is a valid sequence in such binary tree. 

    We get the given string from the concatenation of an array of integers arr and the concatenation of all values of the nodes along a path results in a sequence in the given binary tree.


    Example 1:

    Input: root = [0,1,0,0,1,0,null,null,1,0,0], arr = [0,1,0,1]
    Output: true
    Explanation: 
    The path 0 -> 1 -> 0 -> 1 is a valid sequence (green color in the figure). 
    Other valid sequences are: 
    0 -> 1 -> 1 -> 0 
    0 -> 0 -> 0

    Example 2:

    Input: root = [0,1,0,0,1,0,null,null,1,0,0], arr = [0,0,1]
    Output: false 
    Explanation: The path 0 -> 0 -> 1 does not exist, therefore it is not even a sequence.

    Example 3:

    Input: root = [0,1,0,0,1,0,null,null,1,0,0], arr = [0,1,1]
    Output: false
    Explanation: The path 0 -> 1 -> 1 is a sequence, but it is not a valid sequence.
    

    Constraints:

    1 <= arr.length <= 5000
    0 <= arr[i] <= 9
    Each node's value is between [0 - 9].
    */

    public class ValidSequenceFromRootToLeaves
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

        int nextPosition = 0;
        bool hasLeaf = false;
        public bool IsValidSequence(TreeNode root, int[] arr)
        {
            if (root == null) return false;

            return FindPath(root, arr);
        }

        private bool FindPath(TreeNode node, int[] arr)
        {
            if (node == null) return

            if (node.left != null && nextPosition <= arr.Length - 1 && node.left.val == arr[nextPosition]) // left - left - value // node.left.left.value
            {
                nextPosition++;
                Console.WriteLine("Traversing left node " + nextPosition + " next left node " + node.left.val);
                FindPath(node.left, arr); // left node.left.value - value
            }

            if (node.right != null && nextPosition <= arr.Length - 1 && node.right.val == arr[nextPosition])
            {
                nextPosition++;
                Console.WriteLine("Traversing right node " + nextPosition + " next right node " + node.right.val);
                FindPath(node.right, arr);
            }
            
        }
    }
}