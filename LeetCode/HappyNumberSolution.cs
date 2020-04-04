using System;
using System.Collections.Generic;

namespace DSA.Problems.LeetCode
{
    //https://leetcode.com/problems/happy-number/
    //Write an algorithm to determine if a number is "happy".

    //A happy number is a number defined by the following process: Starting with any positive integer, replace the number by the sum of the squares of its digits, and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. Those numbers for which this process ends in 1 are happy numbers.

    //Example: 

    //Input: 19
    //Output: true
    //Explanation: 
    //12 + 92 = 82
    //82 + 22 = 68
    //62 + 82 = 100
    //12 + 02 + 02 = 1

    // Static void main
    //var number = 19;
    //var happy = new HappyNumberSolution();
    //Console.WriteLine(happy.IsHappy(19));
    class HappyNumberSolution
    {
        public bool IsHappy(int n)
        {
            HashSet<double> hashSet = new HashSet<double>();
            if (n < 10)
            {
                return n == 1 || n == 7;
            }
            double sum = 0;
            double current = n;
            while (sum != 1)
            {
                sum = 0;
                while (current != 0)
                {
                    sum += (current % 10) * (current % 10);
                    current = Math.Floor(current / 10);
                }
                if (hashSet.Contains(sum))
                    return false;
                else
                    hashSet.Add(sum);

                current = sum;
            }

            return true;
        }
    }
}
