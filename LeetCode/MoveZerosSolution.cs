using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.LeetCode
{
    public class MoveZerosSolution
    {
        // https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/567/
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length == 1) return;
            if (Array.Exists(nums, x => x != 0))
            {
                int lastIdx = 0;
                int zeroIdx = Array.FindIndex(nums, lastIdx, x => x == 0);
                while (zeroIdx > -1)
                {
                    //shift to left
                    for (int i = zeroIdx; i < nums.Length; i++)
                    {
                        if (i != nums.Length - 1)
                            nums[i] = nums[i + 1];
                    }
                    nums[nums.Length - 1] = 0;
                    if (nums[lastIdx] != 0)
                    {
                        Console.WriteLine(lastIdx);
                        lastIdx = zeroIdx;
                        zeroIdx = Array.FindIndex(nums, lastIdx + 1, x => x == 0);
                    }
                    else
                    {
                        if (Array.FindIndex(nums, lastIdx, x => x != 0) > -1)
                        {
                            zeroIdx = Array.FindIndex(nums, lastIdx, x => x == 0);
                        }
                        else
                        {
                            zeroIdx = -1;
                        }
                    }
                }
            }
        }
    }
}
