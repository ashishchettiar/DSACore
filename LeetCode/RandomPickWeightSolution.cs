using System;


namespace DSACore.LeetCode
{
    /*
        https://leetcode.com/problems/random-pick-with-weight/
        Given an array w of positive integers, where w[i] describes the weight of index i, write a function pickIndex which randomly picks an index in proportion to its weight.

        Note:

        1 <= w.length <= 10000
        1 <= w[i] <= 10^5
        pickIndex will be called at most 10000 times.
        Example 1:

        Input: 
        ["Solution","pickIndex"]
        [[[1]],[]]
        Output: [null,0]
        Example 2:

        Input: 
        ["Solution","pickIndex","pickIndex","pickIndex","pickIndex","pickIndex"]
        [[[1,3]],[],[],[],[],[]]
        Output: [null,0,1,1,1,0]
        Explanation of Input Syntax:

        The input is two lists: the subroutines called and their arguments. Solution's constructor has one argument, the array w. pickIndex has no arguments. Arguments are always wrapped with a list, even if there aren't any.
    */
    public class RandomPickWeightSolution
    {
        private int[] prefixSums;
        private int totalSum;
        private Random random = new Random();  

        public RandomPickWeightSolution(int[] w)
        {
            this.prefixSums = new int[w.Length];

            int prefixSum = 0;
            for (int i = 0; i < w.Length; ++i)
            {
                prefixSum += w[i];
                this.prefixSums[i] = prefixSum;
            }
            this.totalSum = prefixSum;
        }

        public int PickIndex()
        {
            double target = this.totalSum * random.Next();

            // run a binary search to find the target zone
            int low = 0, high = this.prefixSums.Length;
            while (low < high)
            {
                // better to avoid the overflow
                int mid = low + (high - low) / 2;
                if (target > this.prefixSums[mid])
                    low = mid + 1;
                else
                    high = mid;
            }
            return low;
        }
    }
}