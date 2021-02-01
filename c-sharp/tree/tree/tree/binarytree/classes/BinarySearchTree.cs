using System;
using System.Collections.Generic;
using System.Text;

namespace tree.binarytree.classes
{
  public class BinarySearchTree
  {
    public BinaryTree<int> MyBST { get; set; }

    public BinarySearchTree()
    {
      MyBST = new BinaryTree<int>();
    }

    /// <summary>
    /// This method adds a Node in BST search order
    /// </summary>
    /// <param name="value">The new value being added to the BST</param>
    public void Add(int value)
    {
      Node<int> newNode = new Node<int>(value);

      // checks if the there is a value in the tree starting off
      if (MyBST.Root != null)
      {
        Node<int> current = MyBST.Root;
        bool keepTraversing = true;

        // traverses until a null value is hit and exit flag is triggered
        while (keepTraversing)
        {

          // compares if th value should go to the left side of the tree/subtree or to the right side
          if (newNode.Value < current.Value)
          {
            if(current.LeftChild != null)
            {
              current = current.LeftChild;
            }
            else
            {
              current.LeftChild = newNode;
              keepTraversing = false;
            }
          }// end if
          else
          {
            if(current.RightChild != null)
            {
              current = current.RightChild;
            }
            else
            {
              current.RightChild = newNode;
              keepTraversing = false;
            }
          }// end else
        } // end while 
      }

      // if there isn't a starting node then this makes the new value the starting node
      else
      {
        MyBST.Root = newNode;
      }
    }// end add(value) method

    /// <summary>
    /// Searches to see if a value is contained within the BST
    /// </summary>
    /// <param name="value">value to search for</param>
    /// <returns></returns>
    public bool Contains(int value)
    {
      if(MyBST.Root != null)
      {
        Node<int> current = MyBST.Root;

        while(current != null)
        {
          if(current.Value == value)
          {
            return true;
          }
          else if(value < current.Value)
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
