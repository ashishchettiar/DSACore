using System;
using DSACore.LeetCode;
using DSACore.DataStructures;
using DSACore.Algorithms;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            var trie = new Trie();

            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            
            trie.Insert("hello");
            Console.WriteLine(trie.Search("hell")); // returns false
            Console.WriteLine(trie.Search("helloa"));     // returns false
            Console.WriteLine(trie.Search("hello"));     // returns true
            Console.WriteLine(trie.StartsWith("hell"));     // returns true
            Console.WriteLine(trie.StartsWith("helloa"));     // returns false
            Console.WriteLine(trie.StartsWith("hello"));     // returns true
            
            Console.Read();
        }
    }
}
