using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    public class ContiguousArraySolution
    {
        public int FindMaxLength(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();
            dictionary.Add(0, -1);
            var counter = 0;
            var maxLength = 0;

            for(int i =0; i< nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    counter--;
                }

                if(nums[i] == 1)
                {
                    counter++;
                }

                if(dictionary.ContainsKey(counter))
                {
                    maxLength = Math.Max(maxLength, i-dictionary[counter]);
                }
                else
                {
                    dictionary.Add(counter, i);
                }
            }

            return maxLength;
        }
    }
}