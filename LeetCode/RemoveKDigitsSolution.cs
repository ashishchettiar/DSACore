using System;
using System.Text;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/remove-k-digits/
    Given a non-negative integer num represented as a string, remove k digits from the number so that the new number is the smallest possible.

    Note:
    The length of num is less than 10002 and will be ≥ k.
    The given num does not contain any leading zero.
    Example 1:

    Input: num = "1432219", k = 3
    Output: "1219"
    Explanation: Remove the three digits 4, 3, and 2 to form the new number 1219 which is the smallest.
    Example 2:

    Input: num = "10200", k = 1
    Output: "200"
    Explanation: Remove the leading 1 and the number is 200. Note that the output must not contain leading zeroes.
    Example 3:

    Input: num = "10", k = 2
    Output: "0"
    Explanation: Remove all the digits from the number and it is left with nothing which is 0.
    */
    public class RemoveKDigitsSolution
    {
        public string RemoveKdigits(string num, int k)
        {
            var size = num.Length;
            if(k == size) return "0";
            Stack<char> stack = new Stack<char>();

            var counter = 0;
            while(counter < size)
            {
                while(k > 0 && stack.Count != 0 && stack.Peek() > num[counter])
                {
                    stack.Pop();
                    k--;
                }

                stack.Push(num[counter]);
                counter++;
            }

            while(k>0)
            {
                stack.Pop();
                k--;
            }

            var sb = new StringBuilder();
            while(stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }

            var oldString = sb.ToString();
            var resultArray = oldString.ToCharArray();
            Array.Reverse(resultArray);
            string s = new string(resultArray);
            sb.Replace(oldString, s);
            
            while(sb.Length > 0 && sb[0] == '0')
            {
                sb.Remove(0, 1);
            }

            return sb.ToString() ?? "0";
        }
    }
}
