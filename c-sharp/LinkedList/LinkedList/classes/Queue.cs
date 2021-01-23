using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class Queue<T>
  {
    public Node<T> front { get; set; }

    public void Enqueue(T nodeVal)
    {
      Node<T> newNode = new Node<T>(nodeVal);
      Node<T> current = front;

      if(front == null)
      {
        front = newNode;
      }
      else
      {
        do
        {
          if(current.Next == null)
          {
            current.Next = newNode;
          }

          current = current.Next;
        } while (current.Next != null);
      }
    }

    public Node<T> Dequeue()
    {
      Node<T> removeNode = front;
      front = removeNode.Next;
      removeNode.Next = null;
      return removeNode;
    }

    public T peek()
    {
      if (IsEmpty())
      {
        return front.Value;
      }
      else
      {
        throw new NullReferenceException();
      }
    }

    public bool IsEmpty()
    {
      return front != null;
    }
  }
}
