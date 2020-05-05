using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/first-unique-character-in-a-string/
    Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.

    Examples:

    s = "leetcode"
    return 0.

    s = "loveleetcode",
    return 2.
    Note: You may assume the string contain only lowercase letters.
    */
    public class FirstUniqueCharacterSolution
    {
        private class Dto
        {
            public char Character;
            public int Position;

            public Dto(char character, int position)
            {
                this.Character = character;
                this.Position = position;
            }

            public override int GetHashCode()
            {
                if (this.Character == null) return 0;
                return this.Character.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                Dto other = obj as Dto;
                return other != null && other.Character == this.Character;
            }
        }

        public int FirstUniqChar(string s)
        {
            var characterArray = s.ToCharArray();
            var map = new Dictionary<Dto, int>();
            for (int i = 0; i < characterArray.Length; i++)
            {
                var key = new Dto(characterArray[i], i);
                if (map.ContainsKey(key))
                {
                    map[key] = map[key] + 1;
                }
                else
                {
                    map.Add(key, 1);
                }
            }

            foreach (var item in map)
            {
                if (item.Value == 1) return item.Key.Position;
            }

            return -1;
        }
    }
}