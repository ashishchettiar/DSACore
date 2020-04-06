using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/group-anagrams/
    Given an array of strings, group anagrams together.

    Example:

    Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
    Output:
        [
        ["ate","eat","tea"],
        ["nat","tan"],
        ["bat"]
        ]
    Note:

    All inputs will be in lowercase.
    The order of your output does not matter.

    var input = new string[] {"eat", "tea", "tan", "ate", "nat", "bat"};
    var anagram = new GroupAnagramSolution();
    Console.WriteLine("Pause to attach debugger");
    Console.Read();
    var m = anagram.GroupAnagrams(input);

    */
    public class GroupAnagramSolution 
    {
        public IList<IList<string>> GroupAnagrams(string[] strs) 
        {
            var dictionary = new Dictionary<string, List<string>>();
            var result = new List<IList<string>>();
            foreach (var word in strs)
            {
                var chars = word.ToCharArray();
                Array.Sort(chars);
                var hash = new string(chars);
                if(dictionary.ContainsKey(hash))
                {
                    dictionary[hash].Add(word);
                }
                else
                {
                    dictionary.Add(hash, new List<string>{ word });
                }
            }

            foreach(var item in dictionary)
            {
                result.Add(item.Value);
            }

            return result;
        }
    }
}
