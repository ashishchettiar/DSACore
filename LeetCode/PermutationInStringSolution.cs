using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/permutation-in-string/
    Given two strings s1 and s2, write a function to return true if s2 contains the permutation of s1. In other words, one of the first string's permutations is the substring of the second string.

    Example 1:

    Input: s1 = "ab" s2 = "eidbaooo"
    Output: True
    Explanation: s2 contains one permutation of s1 ("ba").
    Example 2:

    Input:s1= "ab" s2 = "eidboaoo"
    Output: False
    

    Note:

    The input strings only contain lower case letters.
    The length of both given strings is in range [1, 10,000].
    */
    public class PermutationInStringSolution
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length == 0) return false;

            var windowLength = s1.Length;
            var pMap = new Dictionary<char, int>();
            var sMap = new Dictionary<char, int>();

            foreach (var c in s1)
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

            for (int i = 0; i < s2.Length; i++)
            {
                if (!sMap.ContainsKey(s2[i]))
                {
                    sMap.Add(s2[i], 1);
                }
                else
                {
                    sMap[s2[i]] = sMap[s2[i]] + 1;
                }

                if (i >= windowLength)
                {
                    if (sMap[s2[i - windowLength]] == 1)
                    {
                        sMap.Remove(s2[i - windowLength]);
                    }
                    else
                    {
                        sMap[s2[i - windowLength]] = sMap[s2[i - windowLength]] - 1;
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

                if (areEqual) return true;
            }

            return false;
        }
    }
}