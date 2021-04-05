using System;
using System.Linq;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/implement-queue-using-stacks/
    ["QueueUsingStacksSolution","push","push","peek","pop","empty"]
    [[],[1],[2],[],[],[]]   
    */
    public class QueueUsingStacksSolution {

    Stack<int> front = new Stack<int>();
    Stack<int> back = new Stack<int>();
    
    /** Initialize your data structure here. */
    public QueueUsingStacksSolution() {
        
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        back.Push(x);
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        ShiftStacks();
        return front.Pop();
    }
    
    /** Get the front element. */
    public int Peek() {
        ShiftStacks();
        return front.Peek();
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        return front.Count == 0 && back.Count == 0;
    }
    
    void ShiftStacks()
    {
        if(front.Count == 0)
        {
            while(back.Count > 0)
            {
                front.Push(back.Pop());
            }
        }
    }
}
}