using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/majority-element/
    Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.

    You may assume that the array is non-empty and the majority element always exist in the array.

    Example 1:

    Input: [3,2,3]
    Output: 3
    Example 2:

    Input: [2,2,1,1,1,2,2]
    Output: 2
    */
    public class MajorityElementSolution
    {
        public int MajorityElement(int[] nums)
        {
            var map = new Dictionary<int, int>();
            foreach (var n in nums)
            {
                if (map.ContainsKey(n))
                {
                    map[n] = map[n] + 1;
                }
                else
                {
                    map.Add(n, 1);
                }
            }

            var resultCount = 0;
            var result = 0;
            foreach (var item in map)
            {
                if (resultCount < item.Value)
                {
                    resultCount = item.Value;
                    result = item.Key;
                }
            }

            return result;
        }
    }
}