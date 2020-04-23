using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/bitwise-and-of-numbers-range/
    Given a range [m, n] where 0 <= m <= n <= 2147483647, return the bitwise AND of all numbers in this range, inclusive.

    Example 1:

    Input: [5,7]
    Output: 4
    Example 2:

    Solution Explanation:

    5 in bit representation is 0101
    7 in bit representation is 0111

    After shifting both numbers to the right 2 times

    5 becomes 0001 which is 1 in decimal 
    7 becomes 0001 which is 1 in decimal

    To find the result we just have to left shift the new equal number 0001 which is 1 in decimal 2 times

    1 in bit representation is 0001
    After Left shifting 2 times
    0001 becomes 0100 which is 4 in decimal

    */
    public class BitwiseANDofNumbersRangeSolution
    {
        public int RangeBitwiseAnd(int m, int n)
        {
            var counter = 0;

            while(m != n)
            {
                m = m >> 1;
                n = n >> 1;
                counter++;
            }

            return m << counter;
        }
    }
}