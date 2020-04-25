using System;
using System.Collections.Generic;

namespace DSACore.DataStructures
{
    public class LRUCache
    {
        public class ListNode
        {
            public ListNode Next;
            public ListNode Previous;

            public int Key;
            public int Data;

            public ListNode(int key, int data)
            {
                this.Key = key;
                this.Data = data;
            }
        }

        private Dictionary<int, ListNode> dict = new Dictionary<int, ListNode>();
        private ListNode Head = null;
        private ListNode Tail = null;
        private int Capacity = 0;

        public LRUCache(int capacity)
        {
            Capacity = capacity;
            Head = new ListNode(0, 0);
            Tail = new ListNode(0, 0);

            Head.Next = Tail;
            Tail.Previous = Head;
        }

        public int Get(int key)
        {
            if (!dict.ContainsKey(key)) return -1;

            var node = dict[key];
            MoveToFront(node);
            return node.Data;
        }

        public void Put(int key, int value)
        {
            if (!dict.ContainsKey(key))
            {
                var node = new ListNode(key, value);
                AddToFront(node);

                if (dict.Count == Capacity)
                {
                    //remove from map
                    dict.Remove(Tail.Previous.Key);

                    //evict last tail
                    var secondLast = Tail.Previous.Previous;
                    secondLast.Next = null;
                    Tail.Previous = secondLast;
                }

                //add to map
                dict.Add(key, node);
            }
            else
            {
                //move existing item to the head of the linked list
                var node = dict[key];
                node.Data = value;
                MoveToFront(node);
            }
        }

        private void MoveToFront(ListNode node)
        {
            if (Head.Next != node)
            {
                var prev = node.Previous;
                var next = node.Next;

                prev.Next = next;
                if (next != null) next.Previous = prev;

                var prevHead = Head.Next;

                if(Tail.Previous == node) 
                {
                    Tail.Previous = prev;
                }

                prevHead.Previous = node;

                node.Next = prevHead;
                node.Previous = null;
                Head.Next = node;
            }
        }

        private void AddToFront(ListNode node)
        {
            var prevHead = Head.Next;
            prevHead.Previous = node;
            node.Next = prevHead;
            node.Previous = null;
            Head.Next = node;
        }
    }
}
