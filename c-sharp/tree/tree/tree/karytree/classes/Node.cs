using System;
using System.Collections.Generic;
using System.Text;

namespace tree.karytree.classes
{
  public class Node<T>
  {
    public T Value { get; set; }
    public List<Node<T>> Children { get; set; }

    public Node()
    {
      Children = null;
    }

    public Node(T value)
    {
      Value = value;
      Children = null;
    }
  }
}
