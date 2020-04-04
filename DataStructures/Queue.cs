using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.DataStructures
{
    public class Queue
    {
        private class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }

        //pointers
        private Node head; // remove from head
        private Node tail; // add at tail

        //operations
        public bool IsEmpty()
        {
            return head == null;
        }

        public int Peek()
        {
            return head.data;
        }

        public void Add(int data)
        {
            var node = new Node(data);
            if(tail != null)
            {
                tail.next = node;
            }
            tail = node;
            if (head == null)
            {
                head = node;
            }
        }

        public int Remove()
        {
            int headData = head.data;
            head = head.next;
            if(head == null)
            {
                tail = null;
            }
            return headData;
        }
    }
}
