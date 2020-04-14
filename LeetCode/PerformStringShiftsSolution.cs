using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/explore/challenge/card/30-day-leetcoding-challenge/529/week-2/3299/
    You are given a string s containing lowercase English letters, and a matrix shift, where shift[i] = [direction, amount]:

    direction can be 0 (for left shift) or 1 (for right shift). 
    amount is the amount by which string s is to be shifted.
    A left shift by 1 means remove the first character of s and append it to the end.
    Similarly, a right shift by 1 means remove the last character of s and add it to the beginning.
    Return the final string after all operations.

    

    Example 1:

    Input: s = "abc", shift = [[0,1],[1,2]]
    Output: "cab"
    Explanation: 
    [0,1] means shift to left by 1. "abc" -> "bca"
    [1,2] means shift to right by 2. "bca" -> "cab"
    Example 2:

    Input: s = "abcdefg", shift = [[1,1],[1,1],[0,2],[1,3]]
    Output: "efgabcd"
    Explanation:  
    [1,1] means shift to right by 1. "abcdefg" -> "gabcdef"
    [1,1] means shift to right by 1. "gabcdef" -> "fgabcde"
    [0,2] means shift to left by 2. "fgabcde" -> "abcdefg"
    [1,3] means shift to right by 3. "abcdefg" -> "efgabcd"
    

    Constraints:

    1 <= s.length <= 100
    s only contains lower case English letters.
    1 <= shift.length <= 100
    shift[i].length == 2
    0 <= shift[i][0] <= 1
    0 <= shift[i][1] <= 100
    */
    public class PerformStringShiftsSolution
    {
        public string StringShift(string s, int[][] shift)
        {
            var result = string.Empty;
            if (shift.Length == 0) return result;

            int count = 0;
            for (int i = 0; i < shift.Length; i++)
            {
                if (shift[i][0] == 0)
                {

                    count = count - shift[i][1];
                    Console.WriteLine("left => " + count);
                }
                else
                {
                    count = count + shift[i][1];
                    Console.WriteLine("right => " + count);
                }
            }

            if (Math.Abs(count) > s.Length)
            {
                var m = Math.Abs(count) % s.Length;
                if (count < 0)
                {
                    count = m * -1;
                }
                else
                {
                    count = m;
                }
            }
            Console.WriteLine(count);

            if (count > 0) // shift right
            {
                var shiftPart = s.Substring(s.Length - count);
                var body = s.Substring(0, s.Length - count);
                result = shiftPart + body;
            }

            if (count < 0) //shift left
            {
                var shiftPart = s.Substring(0, Math.Abs(count));
                var body = s.Substring(Math.Abs(count));
                result = body + shiftPart;
            }

            if (count == 0) result = s;

            return result;
        }
    }
}
