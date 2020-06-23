using System;
using System.Linq;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/single-number-ii/
    Given a non-empty array of integers, every element appears three times except for one, which appears exactly once. Find that single one.

    Note:

    Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

    Example 1:

    Input: [2,2,3,2]
    Output: 3
    Example 2:

    Input: [0,1,0,1,0,1,99]
    Output: 99
    */
    public class SingleNumberIISolution
    {
        public int SingleNumber(int[] nums)
        {
            if(nums.Length < 3) return nums[0];
            Array.Sort(nums);
            if(nums[0] != nums[1]) return nums[0];
            if(nums[nums.Length - 2] != nums[nums.Length - 1]) return nums[nums.Length - 1];

            var pointer = 1;
            while(pointer <= nums.Length - 1)
            {
                if(nums[pointer] != nums[pointer - 1]) return nums[pointer - 1];
                pointer = pointer + 3;
            }

            return nums[pointer - 1];
        }
    }
}