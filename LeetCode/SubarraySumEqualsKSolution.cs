using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/subarray-sum-equals-k/
    Given an array of integers and an integer k, you need to find the total number of continuous subarrays whose sum equals to k.

    Example 1:
    Input:nums = [1,1,1], k = 2
    Output: 2
    Note:
    The length of the array is in range [1, 20,000].
    The range of numbers in the array is [-1000, 1000] and the range of the integer k is [-1e7, 1e7].
    */
    public class SubarraySumEqualsKSolution
    {
        public int SubarraySum(int[] nums, int k)
        {
            var sum = 0;
            var prefixSum = new Dictionary<int, int>();
            prefixSum.Add(sum, 1);
            var count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (prefixSum.ContainsKey(sum - k))
                {
                    count += prefixSum[sum - k];
                }

                if (prefixSum.ContainsKey(sum))
                {
                    prefixSum[sum] = prefixSum[sum] + 1;
                }
                else
                {
                    prefixSum.Add(sum, 1);
                }
            }

            return count;
        }
    }
}