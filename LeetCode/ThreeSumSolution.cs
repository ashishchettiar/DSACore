using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
        https://leetcode.com/problems/3sum/
        Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

        Notice that the solution set must not contain duplicate triplets.
       
        Example 1:

        Input: nums = [-1,0,1,2,-1,-4]
        Output: [[-1,-1,2],[-1,0,1]]
        Example 2:

        Input: nums = []
        Output: []
        Example 3:

        Input: nums = [0]
        Output: []
        

        Constraints:

        0 <= nums.length <= 3000
        -105 <= nums[i] <= 105
    */
    public class ThreeSumSolution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        for (int i = 0; i < nums.Length && nums[i] <= 0; i++)
            if (i == 0 || nums[i - 1] != nums[i]) {
                TwoSum(nums, i, result);
            }
        return result;
    }
    
    void TwoSum(int[] nums, int i, List<IList<int>> result) {
        int lo = i + 1, hi = nums.Length - 1;
        while (lo < hi) {
            int sum = nums[i] + nums[lo] + nums[hi];
            if (sum < 0) {
                lo++;
            } else if (sum > 0) {
                hi--;
            } else {
                result.Add(new List<int> { nums[i], nums[lo++], nums[hi--] });
                while (lo < hi && nums[lo] == nums[lo - 1])
                    lo++;
            }
        }
    }
}
}