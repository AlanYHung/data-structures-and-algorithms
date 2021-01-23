using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class Node<T>
  {
    public T Value { get; set; }
    public Node<T> Next { get; set; }

    // Constructor
    public Node(T nodeVal)
    {
      Value = nodeVal;
      Next = null;
    }
  }
}
