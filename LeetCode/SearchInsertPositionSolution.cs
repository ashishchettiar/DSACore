using System;
using System.Linq;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/search-insert-position/
    Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

    You may assume no duplicates in the array.

    Example 1:

    Input: [1,3,5,6], 5
    Output: 2
    Example 2:

    Input: [1,3,5,6], 2
    Output: 1
    Example 3:

    Input: [1,3,5,6], 7
    Output: 4
    Example 4:

    Input: [1,3,5,6], 0
    Output: 0
    */
    public class SearchInsertPositionSolution
    {
        public int SearchInsert(int[] nums, int target)
        {
            var low = 0;
            var high = nums.Length - 1;
            var mid = 0;

            if (nums[low] > target) return low;
            if (nums[high] < target) return high + 1;

            while (low < high)
            {
                mid = low + (high - low) / 2;
                if (target > nums[mid])
                {
                    low = mid + 1;
                }
                else if (target < nums[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return nums[low] >= target ? low : low + 1;
        }
    }
}