using System;
using System.Collections.Generic;
using System.Text;

namespace tree.binarytree.classes
{
  public class BinaryTree<T> where T : IComparable
  {
    // The first node in the tree
    public Node<T> Root { get; set; }

    /// <summary>
    /// Traverses a Binary Tree with PreOrder Traversal and returns a dynamic array
    /// https://www.geeksforgeeks.org/tree-traversals-inorder-preorder-and-postorder/
    /// </summary>
    /// <param name="current">current node in traversal</param>
    /// <param name="returnList">list to add to and return</param>
    /// <returns>a list of all values in preorder traversal order</returns>
    public List<T> PreOrder(Node<T> current, List<T> returnList)
    {
      if(current != null)
      {
        returnList.Add(current.Value);
        PreOrder(current.LeftChild, returnList);
        PreOrder(current.RightChild, returnList);
      }

      return returnList;
    }

    /// <summary>
    /// Traverses a Binary Tree with InOrder Traversal and returns a dynamic array
    /// https://www.geeksforgeeks.org/tree-traversals-inorder-preorder-and-postorder/
    /// </summary>
    /// <param name="current">current node in traversal</param>
    /// <param name="returnList">list to add to and return</param>
    /// <returns>a list of all values in inorder traversal order</returns>
    public List<T> InOrder(Node<T> current, List<T> returnList)
    {
      if (current != null)
      {
        InOrder(current.LeftChild, returnList);
        returnList.Add(current.Value);
        InOrder(current.RightChild, returnList);
      }

      return returnList;
    }

    /// <summary>
    /// Traverses a Binary Tree with PostOrder Traversal and returns a dynamic array
    /// https://www.geeksforgeeks.org/tree-traversals-inorder-preorder-and-postorder/
    /// </summary>
    /// <param name="current">current node in traversal</param>
    /// <param name="returnList">list to add to and return</param>
    /// <returns>a list of all values in postorder traversal order</returns>
    public List<T> PostOrder(Node<T> current, List<T> returnList)
    {
      if (current != null)
      {
        PostOrder(current.LeftChild, returnList);
        PostOrder(current.RightChild, returnList);
        returnList.Add(current.Value);
      }

      return returnList;
    }

    /// <summary>
    /// This function finds the largest value in a tree and returns it
    /// </summary>
    /// <returns>largest value in the tree</returns>
    public T FindMaximumValue()
    {
      if (Root == null)
      {
        throw new NullReferenceException();
      }
      else
      {
        return FindMaximumValue(Root, Root.Value);
      }
    }

    /// <summary>
    /// Helper/Overload Function for FindMaxValue
    /// </summary>
    /// <param name="current">current node position in tree</param>
    /// <param name="maxValue">current largest value</param>
    /// <returns>largest value in tree</returns>
    private T FindMaximumValue(Node<T> current, T maxValue)
    {
      if (current != null)
      {
        if (current.Value.CompareTo(maxValue) > 0)
        {
          maxValue = current.Value;
        }

        maxValue = FindMaximumValue(current.LeftChild, maxValue);
        maxValue = FindMaximumValue(current.RightChild, maxValue);
      }

      return maxValue;
    }

    /// <summary>
    /// Traverses a tree using Breadth First Search and returns a List of the nodes in search order
    /// </summary>
    /// <returns>List of values in Breadth First Search order</returns>
    public List<T> BreadthFirst()
    {
      Queue<Node<T>> q = new Queue<Node<T>>();
      List<T> returnList = new List<T>();
      Node<T> tempNode = new Node<T>();

      if (Root != null)
      {
        q.Enqueue(Root);

        do
        {
          tempNode = q.Dequeue();
          returnList.Add(tempNode.Value);

          if (tempNode.LeftChild != null)
          {
            q.Enqueue(tempNode.LeftChild);
          }

          if (tempNode.RightChild != null)
          {
            q.Enqueue(tempNode.RightChild);
          }
        } while (q.Count > 0);

        return returnList;
      }
      else
      {
        throw new NullReferenceException();
      }
    }// End BreadthFirst method
  }
}
