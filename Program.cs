using System;
using DSACore.LeetCode;
using DSACore.DataStructures;

namespace DSACore
{
    class Program
    {
        static void Main(string[] args)
        {
            var cache = new LRUCache(3);
            Console.WriteLine("Pause to attach debugger");
            Console.Read();
            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Put(3, 3);
            cache.Put(4, 4);
            Console.WriteLine(cache.Get(4));
            Console.WriteLine(cache.Get(3));
            Console.WriteLine(cache.Get(2));
            Console.WriteLine(cache.Get(1));
            cache.Put(5, 5);
            Console.WriteLine(cache.Get(1));
            Console.WriteLine(cache.Get(2));
            Console.WriteLine(cache.Get(3));
            Console.WriteLine(cache.Get(4));
            Console.WriteLine(cache.Get(5));
            Console.WriteLine();
            Console.Read();
        }
    }
}
