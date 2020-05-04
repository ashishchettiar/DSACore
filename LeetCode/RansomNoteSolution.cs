using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/ransom-note/
    Given an arbitrary ransom note string and another string containing letters from all the magazines, write a function that will return true if the ransom note can be constructed from the magazines ; otherwise, it will return false.

    Each letter in the magazine string can only be used once in your ransom note.

    Note:
    You may assume that both strings contain only lowercase letters.

    canConstruct("a", "b") -> false
    canConstruct("aa", "ab") -> false
    canConstruct("aa", "aab") -> true
    */
    public class RansomNoteSolution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var availableChars = new Dictionary<char, int>();

            foreach(var c in magazine)
            {
                if(availableChars.ContainsKey(c))
                {
                    availableChars[c] = availableChars[c] + 1;
                }
                else
                {
                    availableChars.Add(c, 1);
                }
            }

            foreach(char r in ransomNote)
            {
                if(!availableChars.ContainsKey(r) || availableChars[r] <= 0)
                {
                    return false;
                }
                availableChars[r] = availableChars[r] - 1;
            }

            return true;
        }
    }
}