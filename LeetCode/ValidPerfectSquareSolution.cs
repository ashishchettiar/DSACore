using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/valid-perfect-square/
    */
    public class ValidPerfectSquareSolution
    {
        public bool IsPerfectSquare(int num)
        {
            if (num <= 2) return true;

            long high = num / 2;
            long low = 1;
            long tempSq = 0;

            while (low <= high)
            {
                var mid = low + (high - low) / 2;
                tempSq = mid*mid;
                if (tempSq == num)
                {
                    return true;
                }
                else if (tempSq > num)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return false;
        }
    }
}