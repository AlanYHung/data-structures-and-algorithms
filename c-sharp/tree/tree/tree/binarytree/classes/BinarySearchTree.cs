using System;
using System.Collections.Generic;
using System.Text;

namespace tree.binarytree.classes
{
  public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
  {
    /// <summary>
    /// This method adds a Node in BST search order
    /// </summary>
    /// <param name="value">The new value being added to the BST</param>
    public void Add(Node<T> current, T value)
    {
      Node<T> newNode = new Node<T>(value);

      if(Root == null)
      {
        Root = newNode;
        return;
      }

      if(newNode.Value.CompareTo(current.Value) < 0)
      {
        if(current.LeftChild == null)
        {
          current.LeftChild = newNode;
        }
        else
        {
          Add(current.LeftChild, value);
        }
      }
      else if (newNode.Value.CompareTo(current.Value) > 0)
      {
        if (current.RightChild == null)
        {
          current.RightChild = newNode;
        }
        else
        {
          Add(current.RightChild, value);
        }
      }
    }// end add(value) method

    /// <summary>
    /// Searches to see if a value is contained within the BST
    /// </summary>
    /// <param name="value">value to search for</param>
    /// <returns></returns>
    public bool Contains(T value)
    {
      if(Root != null)
      {
        Node<T> current = Root;

        while(current != null)
        {
          if(current.Value.Equals(value))
          {
            return true;
          }
          else if(value.CompareTo(current.Value) < 0)
          {
            current = current.LeftChild;
          }
          else
          {
            current = current.RightChild;
          }
        }
      }
      else
      {
        throw new NullReferenceException();
      }

      return false;
    }
  }// end of class
}// end of namespace
