using System;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/valid-parenthesis-string/
    Given a string containing only three types of characters: '(', ')' and '*', write a function to check whether this string is valid. We define the validity of a string by these rules:

    Any left parenthesis '(' must have a corresponding right parenthesis ')'.
    Any right parenthesis ')' must have a corresponding left parenthesis '('.
    Left parenthesis '(' must go before the corresponding right parenthesis ')'.
    '*' could be treated as a single right parenthesis ')' or a single left parenthesis '(' or an empty string.
    An empty string is also valid.
    Example 1:
    Input: "()"
    Output: True
    Example 2:
    Input: "(*)"
    Output: True
    Example 3:
    Input: "(*))"
    Output: True
    Note:
    The string size will be in the range [1, 100].
    */
    public class ValidParenthesisStringSolution
    {
        private class Dto
        {
            public char Parenthesis;
            public int Position;
            public Dto(char parenthesis, int position)
            {
                this.Parenthesis = parenthesis;
                this.Position = position;
            }
        }
        public bool CheckValidString(string s)
        {
            var stack = new Stack<Dto>();
            var starStack = new Stack<Dto>();

            var charArray = s.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '(')
                {
                    stack.Push(new Dto(charArray[i], i));
                }
                if (charArray[i] == '*')
                {
                    starStack.Push(new Dto(charArray[i], i));
                }

                if (charArray[i] == ')')
                {
                    if (stack.Count != 0) stack.Pop();
                    else if (starStack.Count != 0) starStack.Pop();
                    else return false;
                }
            }

            if (stack.Count == 0 && starStack.Count == 0) return true;

            while (stack.Count != 0 && starStack.Count != 0)
            {
                if (stack.Peek().Position > starStack.Peek().Position) return false;
                stack.Pop();
                starStack.Pop();
            }

            return stack.Count == 0;
        }
    }
}