using System;
using System.Linq;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/largest-divisible-subset/
    Given a set of distinct positive integers, find the largest subset such that every pair (Si, Sj) of elements in this subset satisfies:

    Si % Sj = 0 or Sj % Si = 0.

    If there are multiple solutions, return any subset is fine.

    Example 1:

    Input: [1,2,3]
    Output: [1,2] (of course, [1,3] will also be ok)
    Example 2:

    Input: [1,2,4,8]
    Output: [1,2,4,8]
    */
    public class LargestDivisibleSubsetSolution
    {
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            // Test case with empty set.
            int n = nums.Length;
            if (n == 0) return new List<int>();

            var result = new List<List<int>>();
            foreach (var num in nums) result.Add(new List<int>());

            /* Sort the original list in ascending order. */
            Array.Sort(nums);

            /* Calculate all the values of EDS(X_i) */
            for (int i = 0; i < n; ++i)
            {
                var maxSubset = new List<int>();


                // Find the largest divisible subset of previous elements.
                for (int k = 0; k < i; ++k)
                    if (nums[i] % nums[k] == 0 && maxSubset.Count < result[k].Count)
                        maxSubset = result[k];

                // Extend the found subset with the element itself.
                result[i].AddRange(maxSubset);
                result[i].Add(nums[i]);
            }

            /* Find the largest of EDS values  */
            var ret = new List<int>();
            for (int i = 0; i < n; ++i)
                if (ret.Count < result[i].Count) ret = result[i];
            return ret;
        }
    }
}
