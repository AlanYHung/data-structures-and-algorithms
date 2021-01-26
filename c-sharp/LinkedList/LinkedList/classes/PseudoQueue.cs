using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class PseudoQueue<T>
  {
    public Stack<T> QueueWithStack { get; set; }

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

    public Node<T> dequeue()
    {
      // enqueue keeps list in FIFO order, so just use predefined pop method to get the value.
      return QueueWithStack.Pop();
    }
  }
}
