using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/counting-bits/submissions/
    Given a non negative integer number num. For every numbers i in the range 0 ≤ i ≤ num calculate the number of 1's in their binary representation and return them as an array.

    Example 1:

    Input: 2
    Output: [0,1,1]
    Example 2:

    Input: 5
    Output: [0,1,1,2,1,2]
    Follow up:

    It is very easy to come up with a solution with run time O(n*sizeof(integer)). But can you do it in linear time O(n) /possibly in a single pass?
    Space complexity should be O(n).
    Can you do it like a boss? Do it without using any builtin function like __builtin_popcount in c++ or in any other language.
    */
    public class CountingBitsSolution
    {
        public int[] CountBits(int num)
        {
            int[] ans = new int[num + 1];
            for (int i = 0; i <= num; ++i)
                ans[i] = popcount(i);
            return ans;
        }
        private int popcount(int x)
        {
            int count;
            for (count = 0; x != 0; ++count)
                x &= x - 1;
            return count;
        }
    }
}