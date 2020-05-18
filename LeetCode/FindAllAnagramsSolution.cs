using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/find-all-anagrams-in-a-string/
    Given a string s and a non-empty string p, find all the start indices of p's anagrams in s.

    Strings consists of lowercase English letters only and the length of both strings s and p will not be larger than 20,100.

    The order of output does not matter.

    Example 1:

    Input:
    s: "cbaebabacd" p: "abc"

    Output:
    [0, 6]

    Explanation:
    The substring with start index = 0 is "cba", which is an anagram of "abc".
    The substring with start index = 6 is "bac", which is an anagram of "abc".
    Example 2:

    Input:
    s: "abab" p: "ab"

    Output:
    [0, 1, 2]

    Explanation:
    The substring with start index = 0 is "ab", which is an anagram of "ab".
    The substring with start index = 1 is "ba", which is an anagram of "ab".
    The substring with start index = 2 is "ab", which is an anagram of "ab".
    */
    public class FindAllAnagramsSolution
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var output = new List<int>();
            if (s.Length < p.Length || p.Length == 0) return output;

            var windowLength = p.Length;
            var pMap = new Dictionary<char, int>();
            var sMap = new Dictionary<char, int>();

            foreach (var c in p)
            {
                if (!pMap.ContainsKey(c))
                {
                    pMap.Add(c, 1);
                }
                else
                {
                    pMap[c] = pMap[c] + 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (!sMap.ContainsKey(s[i]))
                {
                    sMap.Add(s[i], 1);
                }
                else
                {
                    sMap[s[i]] = sMap[s[i]] + 1;
                }

                if (i >= windowLength)
                {
                    if (sMap[s[i - windowLength]] == 1)
                    {
                        sMap.Remove(s[i - windowLength]);
                    }
                    else
                    {
                        sMap[s[i - windowLength]] = sMap[s[i - windowLength]] - 1;
                    }
                }

                //check if chars and counts equal
                var areEqual = true;
                foreach (var kv in pMap)
                {
                    if (!sMap.ContainsKey(kv.Key))
                    {
                        areEqual = false;
                        break;
                    }

                    if (sMap.ContainsKey(kv.Key) && sMap[kv.Key] != kv.Value)
                    {
                        areEqual = false;
                    }
                }

                if (areEqual) output.Add(i - windowLength + 1);
            }

            return output;
        }
    }
}