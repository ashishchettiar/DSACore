using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/sort-characters-by-frequency/
    Given a string, sort it in decreasing order based on the frequency of characters.

    Example 1:

    Input:
    "tree"

    Output:
    "eert"

    Explanation:
    'e' appears twice while 'r' and 't' both appear once.
    So 'e' must appear before both 'r' and 't'. Therefore "eetr" is also a valid answer.
    Example 2:

    Input:
    "cccaaa"

    Output:
    "cccaaa"

    Explanation:
    Both 'c' and 'a' appear three times, so "aaaccc" is also a valid answer.
    Note that "cacaca" is incorrect, as the same characters must be together.
    Example 3:

    Input:
    "Aabb"

    Output:
    "bbAa"

    Explanation:
    "bbaA" is also a valid answer, but "Aabb" is incorrect.
    Note that 'A' and 'a' are treated as two different characters.
    */
    public class SortCharactersByFrequencySolution
    {
        public string FrequencySort(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            var sb = new StringBuilder();
            var dict = new Dictionary<char, int>();
            var sorted = new SortedDictionary<int, List<char>>();

            foreach (var c in s)
            { 
                if(dict.ContainsKey(c))
                {
                    dict[c] = dict[c] + 1;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            foreach(var kvp in dict)
            {
                if(sorted.ContainsKey(kvp.Value))
                {
                    sorted[kvp.Value].Add(kvp.Key);
                }
                else
                {
                    sorted.Add(kvp.Value, new List<char> { kvp.Key });
                }
            }

            foreach(var svp in sorted.Reverse())
            {
                foreach(var c in svp.Value)
                {
                    sb.Append(c, svp.Key);
                }
            }

            return sb.ToString();
        }
    }
}