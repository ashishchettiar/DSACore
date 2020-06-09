using System;
using System.Linq;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/power-of-two/
    Given an integer, write a function to determine if it is a power of two.

    Example 1:

    Input: 1
    Output: true 
    Explanation: 20 = 1
    Example 2:

    Input: 16
    Output: true
    Explanation: 24 = 16
    Example 3:

    Input: 218
    Output: false
    */
    public class PowerOfTwoSolution
    {
        public bool IsPowerOfTwo(int n)
        {
            long i = 1;
            while(i < n)
            {
                i = i*2;
            }
            return i == n;
        }
    }
}