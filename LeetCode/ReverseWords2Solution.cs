using System;

namespace DSACore.LeetCode
{
    //LC: https://leetcode.com/explore/interview/card/amazon/76/array-and-strings/522/
    class ReverseWords2Solution
    {
        public void ReverseWords(char[] str)
        {
            Array.Reverse(str);
            int startIndex = 0;
            int stopIndex = 0;
            int i = 0;
            char temp;

            while (i < str.Length)
            {
                while (i < str.Length && str[i] != ' ')
                {
                    i++;
                }
                stopIndex = i - 1;

                int j = startIndex;
                while (j < stopIndex)
                {
                    temp = str[stopIndex];
                    str[stopIndex] = str[j];
                    str[j] = temp;
                    stopIndex--;
                    j++;
                }
                i++;
                startIndex = i;
            }
        }
    }
}
