using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.LeetCode
{
    class MaximumSubArraySolution
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int max = nums[0];
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum <= 0)
                {
                    sum = 0;
                    max = GetMax(max, nums[i]);
                }
                else
                {
                    max = GetMax(max, sum);
                }
            }

            return max;
        }

        private int GetMax(int n1, int n2)
        {
            if (n1 > n2) return n1;
            return n2;
        }
    }
}
