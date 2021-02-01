using System;
using System.Collections.Generic;
using System.Text;

namespace tree.binarytree.classes
{
  public class Node<T>
  {
    public T Value { get; set; }
    public Node<T> LeftChild { get; set; }
    public Node<T> RightChild { get; set; }

    public Node()
    {
      LeftChild = null;
      RightChild = null;
    }

    public Node( T value, Node<T> leftChild = null, Node<T> rightChild = null)
    {
      Value = value;
      LeftChild = leftChild;
      RightChild = rightChild;
    }
  }
}
