using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/check-if-it-is-a-straight-line/
    */
    public class CheckIfStraightLineSolution
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            decimal slope = 0;

            //calculate slope
            for(int i = 0; i < coordinates.Length - 1; i++)
            {
                var current = coordinates[i];
                var next = coordinates[i + 1];

                decimal x = current[0] - next[0];
                decimal y = current[1] - next[1];

                if(x == 0) return false;
                
                decimal currentSlope = (decimal)y/(decimal)x;

                if(i == 0) slope = currentSlope;

                if(currentSlope != slope) return false;
            }

            return true;
        }
    }
}