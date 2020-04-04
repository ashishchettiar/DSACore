using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.LeetCode
{
    public class DuplicateNumberSolution
    {
        //LC: https://leetcode.com/explore/interview/card/amazon/76/array-and-strings/496/
        public int FindDuplicate(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (hash.Contains(nums[i]))
                {
                    return nums[i];
                }
                else
                {
                    hash.Add(nums[i]);
                }
            }
            return 0;
        }
    }
}
