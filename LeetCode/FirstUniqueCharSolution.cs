using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSACore.LeetCode
{
    public class FirstUniqueCharSolution
    {

        //LC: https://leetcode.com/explore/interview/card/amazon/76/array-and-strings/480/
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            var arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }

            var e = dict.GetEnumerator();
            while (e.MoveNext())
            {
                var kvp = e.Current;
                if (kvp.Value == 1)
                {
                    return Array.FindIndex(s.ToCharArray(), x => kvp.Key == x);
                }
            }

            return -1;
        }
    }
}
