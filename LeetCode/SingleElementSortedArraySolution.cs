using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/single-element-in-a-sorted-array/
    You are given a sorted array consisting of only integers where every element appears exactly twice, except for one element which appears exactly once. Find this single element that appears only once.

    Example 1:

    Input: [1,1,2,3,3,4,4,8,8]
    Output: 2
    Example 2:

    Input: [3,3,7,7,10,11,11]
    Output: 10
    

    Note: Your solution should run in O(log n) time and O(1) space.
    */
    public class SingleElementSortedArraySolution
    {
        public int SingleNonDuplicate(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            var even = 0;
            var odd = 1;

            while (even < nums.Length)
            {
                if (odd >= nums.Length || nums[even] != nums[odd])
                {
                    return nums[even];
                }
                even = even + 2;
                odd = odd + 2;
            }
            return 0;
        }
    }
}