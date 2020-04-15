using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/product-of-array-except-self/
    Given an array nums of n integers where n > 1,  return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].

    Example:

    Input:  [1,2,3,4]
    Output: [24,12,8,6]
    Constraint: It's guaranteed that the product of the elements of any prefix or suffix of the array (including the whole array) fits in a 32 bit integer.

    Note: Please solve it without division and in O(n).

    Follow up:
    Could you solve it with constant space complexity? (The output array does not count as extra space for the purpose of space complexity analysis.)
    */
    public class ProductOfArrayExceptSelfSolution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var left = new int[nums.Length];
            var right = new int[nums.Length];
            var result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    left[0] = 1;
                }
                else
                {
                    left[i] = nums[i - 1] * left[i - 1];
                }
            }


            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i == nums.Length - 1)
                {
                    right[nums.Length - 1] = 1;
                }
                else
                {
                    right[i] = nums[i + 1] * right[i + 1];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = left[i] * right[i];
            }

            return result;
        }
    }
}