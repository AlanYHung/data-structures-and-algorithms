using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class Node<T>
  {
    public T Value { get; set; }
    public Node<T> Next { get; set; }

    public Node()
    {
      Next = null;
    }

    // Constructor
    public Node(T nodeVal)
    {
      Value = nodeVal;
      Next = null;
    }
  }
}
