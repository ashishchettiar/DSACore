using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
        https://leetcode.com/problems/intersection-of-two-arrays/
        Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must be unique and you may return the result in any order.

        Example 1:

        Input: nums1 = [1,2,2,1], nums2 = [2,2]
        Output: [2]
        Example 2:

        Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
        Output: [9,4]
        Explanation: [4,9] is also accepted.
        

        Constraints:

        1 <= nums1.length, nums2.length <= 1000
        0 <= nums1[i], nums2[i] <= 1000
    */
    public class IntersectionofTwoArraysSolution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();
        
        foreach(int num in nums1)
        {
            set1.Add(num);
        }
        
        foreach(int num in nums2)
        {
            set2.Add(num);
        }
        
        if(set1.Count < set2.Count) return GetIntersection(set1, set2);
        return GetIntersection(set2, set1);
    }
    
    int[] GetIntersection(HashSet<int> set1, HashSet<int> set2)
    {
        List<int> result = new List<int>();
        foreach(int num in set2)
        {
            if(set1.Contains(num))
            {
                result.Add(num);
            }
        }
        return result.ToArray();
    }
}
}