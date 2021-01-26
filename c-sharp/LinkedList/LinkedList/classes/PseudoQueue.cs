using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class PseudoQueue<T>
  {
    public Stack<T> QueueWithStack { get; set; }

    public PseudoQueue()
    {
      Stack<T> newStack = new Stack<T>();
      QueueWithStack = newStack;
    }

    public void enqueue(T value)
    {
      Stack<T> tempStack = new Stack<T>();

      // if stack is empty push the value into the Stack
      if (QueueWithStack.IsEmpty())
      {
        QueueWithStack.Push(value);
      }
      else
      {
        // Reverse the Current Stack into a temporary stack
        while (!QueueWithStack.IsEmpty())
        {
          tempStack.Push(QueueWithStack.Pop().Value);
        }

        // Add the new value to the bottom of the list
        QueueWithStack.Push(value);

        // Put the stack back in normal order to mimic FIFO
        while (!tempStack.IsEmpty())
        {
          QueueWithStack.Push(tempStack.Pop().Value);
        }
      }// end else
    }// end enqueue

    public T dequeue()
    {
      // Throw Exception if dequeue is called when stack is empty
      if (QueueWithStack.IsEmpty())
      {
        throw new NullReferenceException();
      }
      else
      {
        return QueueWithStack.Pop().Value;
      }
    }// end dequeue
  }
}
