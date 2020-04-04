
namespace DSA.Problems.LeetCode
{
    // LC: https://leetcode.com/explore/interview/card/amazon/76/array-and-strings/492/
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
