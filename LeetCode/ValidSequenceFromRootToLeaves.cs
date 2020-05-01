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

        public bool IsValidSequence(TreeNode root, int[] arr)
        {
            if (root == null || arr == null) return false;
            int nextPosition = 0;
            return FindPath(root, arr, nextPosition);
        }

        private bool FindPath(TreeNode node, int[] arr, int nextPosition)
        {
            if(node == null) return false;
            else if(nextPosition == arr.Length) 
            {
                Console.WriteLine("next position is " + nextPosition);
                return false;
            }
            else if(arr[nextPosition] != node.val)
            { 
                Console.WriteLine("node value " + node.val + " arr value " + arr[nextPosition] + " next pos " + nextPosition);
                return false;
            }
            else if(node.left == null && node.right == null && nextPosition == arr.Length - 1) return true;

            return FindPath(node.left, arr, nextPosition + 1) || FindPath(node.right, arr, nextPosition + 1);
        }
    }
}