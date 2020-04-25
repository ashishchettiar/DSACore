using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSACore.DataStructures
{
    public class ListNode
    {
        public ListNode Next;
        public ListNode Previous;

        public int Data;

        public ListNode(int data)
        {
            this.Data = data;
        }
    }

    public class LRUCache
    {
        private Dictionary<int, ListNode> dict = new Dictionary<int, ListNode>();

        public LRUCache(int capacity)
        {

        }

        public int Get(int key)
        {
            if(dict.ContainsKey(key))
            {
                //dict.Add(key, new LoaderOptimization)
            }

            return 0;
        }

        public void Put(int key, int value)
        {
            if(!dict.ContainsKey(key))
            {
                var node = new ListNode(value);
                dict.Add(key, node);
            }
            else
            {
                //move existing item to the head of the linked list
            }
        }
    }
}
