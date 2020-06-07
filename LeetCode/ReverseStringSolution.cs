
namespace DSACore.LeetCode
{
    /* LC: https://leetcode.com/explore/interview/card/amazon/76/array-and-strings/492/
        https://leetcode.com/problems/reverse-string/
        Write a function that reverses a string. The input string is given as an array of characters char[].

        Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

        You may assume all the characters consist of printable ascii characters.

        

        Example 1:

        Input: ["h","e","l","l","o"]
        Output: ["o","l","l","e","h"]
        Example 2:

        Input: ["H","a","n","n","a","h"]
        Output: ["h","a","n","n","a","H"]
    */
    public class ReverseStringSolution
    {
        public void ReverseString(char[] s)
        {
            int j = s.Length - 1;
            char temp;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == j || j < i) break;
                temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                j--;
            }
        }
    }
}
