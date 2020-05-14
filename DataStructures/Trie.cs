using System;
using System.Collections.Generic;
using System.Text;

namespace DSACore.DataStructures
{
    /*
    https://leetcode.com/problems/implement-trie-prefix-tree/
    Implement a trie with insert, search, and startsWith methods.

    Example:

    Trie trie = new Trie();

    trie.insert("apple");
    trie.search("apple");   // returns true
    trie.search("app");     // returns false
    trie.startsWith("app"); // returns true
    trie.insert("app");   
    trie.search("app");     // returns true
    Note:

    You may assume that all inputs are consist of lowercase letters a-z.
    All inputs are guaranteed to be non-empty strings.
    */
    public class Trie
    {
        Node root;

        private class Node
        {
            public bool IsWord;
            public char Character;
            public List<Node> Children;

            public Node(char c)
            {
                this.Character = c;
                this.Children = new List<Node>();
            }

            public Node FindChildNode(char c)
            {
                foreach (var child in Children)
                {
                    if (child.Character == c) return child;
                }
                return null;
            }

            public bool IsLeafNode()
            {
                return Children.Count == 0;
            }
        }

        /** Initialize your data structure here. */
        public Trie()
        {
            root = new Node('^');
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            var current = root;
            foreach (var c in word)
            {
                var found = current.FindChildNode(c);
                if (found != null)
                {
                    current = found;
                }
                else
                {
                    var add = new Node(c);
                    current.Children.Add(add);
                    current = add;
                }
            }
            current.IsWord = true;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            var current = root;
            foreach (var c in word)
            {
                var found = current.FindChildNode(c);
                if (found != null)
                {
                    current = found;
                }
                else
                {
                    return false;
                }
            }

            return current != null && current.IsWord;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            var current = root;
            foreach (var c in prefix)
            {
                var found = current.FindChildNode(c);
                if (found == null)
                {
                    return false;
                }
                current = found;
            }
            return current != null && current.Character != '^';
        }
    }
}