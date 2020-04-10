using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

    push(x) -- Push element x onto stack.
    pop() -- Removes the element on top of the stack.
    top() -- Get the top element.
    getMin() -- Retrieve the minimum element in the stack.
    

    Example:

    MinStack minStack = new MinStack();
    minStack.push(-2);
    minStack.push(0);
    minStack.push(-3);
    minStack.getMin();   --> Returns -3.
    minStack.pop();
    minStack.top();      --> Returns 0.
    minStack.getMin();   --> Returns -2.
    */



    public class MinStackSolution
    {

        private Stack<int> stack;
        private Stack<int> tracker;

        public MinStackSolution()
        {
            stack = new Stack<int>();
            tracker = new Stack<int>();
        }

        public void Push(int x)
        {
            if (stack.Count != 0)
            {
                var currentMin = tracker.Peek();
                if(currentMin > x)
                {
                    stack.Push(x);
                    tracker.Push(x);
                }
                else
                {
                    stack.Push(x);
                    tracker.Push(currentMin);
                }
            }
            else
            {
                stack.Push(x);
                tracker.Push(x);
            }
        }

        public void Pop()
        {
            if (stack.Count != 0)
            {
                stack.Pop(); 
                tracker.Pop();
            }
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return tracker.Peek();
        }
    }
}