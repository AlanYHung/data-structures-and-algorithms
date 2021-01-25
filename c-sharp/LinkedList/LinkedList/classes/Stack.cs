using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class Stack<T>
  {
    public Node<T> top { get; set; }

    public void Push(T nodeVal)
    {
      Node<T> newNode = new Node<T>(nodeVal);
      newNode.Next = top;
      top = newNode;
    }

    public Node<T> Pop()
    {
      Node<T> removeNode = top;
      top = removeNode.Next;
      removeNode.Next = null;
      return removeNode;
    }

    public T peek()
    {
      if (!IsEmpty())
      {
        return top.Value;
      }
      else
      {
        throw new NullReferenceException();
      }
    }

    public bool IsEmpty()
    {
      return top == null;
    }
  }
}
