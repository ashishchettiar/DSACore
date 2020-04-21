using System;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/search-in-rotated-sorted-array/
    Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.

   (i.e., [0,1,2,4,5,6,7] might become [4,5,6,7,0,1,2]).

   You are given a target value to search. If found in the array return its index, otherwise return -1.

   You may assume no duplicate exists in the array.

   Your algorithm's runtime complexity must be in the order of O(log n).

   Example 1:

   Input: nums = [4,5,6,7,0,1,2], target = 0
   Output: 4
   Example 2:

   Input: nums = [4,5,6,7,0,1,2], target = 3
   Output: -1
    */
    public class SearchRotatedSortedArraySolution
    {
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return -1;

            return Find(0, nums.Length - 1, nums, target);
        }

        private int Find(int low, int high, int[] nums, int target)
        {
            var mid = (high - low) / 2;

            if (nums[low] < nums[high])
            {
                return FindLinear(low, high, nums, target);
            }
            else
            {
                //continue binary search
                if (target == nums[mid]) return mid;

                if (nums[mid] < nums[high] && target <= nums[high] && target > nums[mid])
                {
                    return Find(mid, high, nums, target);
                }

                if (nums[mid] > nums[low] && target >= nums[low] && target < nums[mid])
                {
                    return Find(low, mid - 1, nums, target);
                }

                if(nums[low] > nums[mid])
                {
                    return FindLinear(low, mid - 1, nums, target);
                }
                else
                {
                    return FindLinear(mid + 1, high, nums, target);
                }
            }
        }

        private int FindLinear(int low, int high, int[] nums, int target)
        {
            int idx = -1;
            for (int i = low; i <= high; i++)
            {
                if (nums[i] == target) return i;
            }

            return idx;
        }
    }
}