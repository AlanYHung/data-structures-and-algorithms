using System;
using System.Collections.Generic;
using System.Text;

namespace tree.binarytree.classes
{
  public class BinaryTree<T>
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
  }
}
