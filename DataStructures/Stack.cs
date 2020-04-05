using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSACore.DataStructures
{
    public class Stack
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

        private Node top;

        public bool IsEmpty()
        {
            return top == null;
        }

        public int Peek()
        {
            return top.data;
        }

        public void Push(int data)
        {
            var node = new Node(data);
            if(top != null)
            {
                var previous = top;
                node.next = previous;
            }
            top = node;
        }

        public int Pop()
        {
            int data = 0;
            if(top != null)
            {
                data = top.data;
                top = top.next;
            }
            return data;
        }
    }
}
