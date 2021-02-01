using System;
using System.Collections.Generic;
using tree.binarytree.classes;

namespace tree
{
  class Program
  {
    static BinaryTree<string> myTree = new BinaryTree<string>();

    static void Main(string[] args)
    {
      List<string> treeList = new List<string>();

      PopulateBinaryTree();
      treeList = myTree.PreOrder(myTree.Root, treeList);
      Console.Write("Pre-Order Tree:  ");

      foreach (string value in treeList)
      {
        Console.Write("{0} ", value);
      }

      Console.WriteLine();
      treeList = new List<string>();
      treeList = myTree.InOrder(myTree.Root, treeList);
      Console.Write("In-Order Tree:  ");

      foreach (string value in treeList)
      {
        Console.Write("{0} ", value);
      }


      Console.WriteLine();
      treeList = new List<string>();
      treeList = myTree.PostOrder(myTree.Root, treeList);
      Console.Write("In-Order Tree:  ");

      foreach (string value in treeList)
      {
        Console.Write("{0} ", value);
      }

      Console.WriteLine("\n\n");
    }

    public static void PopulateBinaryTree()
    {
      myTree.Root = new Node<string>("25");

      myTree.Root.LeftChild = new Node<string>("15");
      myTree.Root.RightChild = new Node<string>("50");

      myTree.Root.LeftChild.LeftChild = new Node<string>("10");
      myTree.Root.LeftChild.RightChild = new Node<string>("22");
      myTree.Root.RightChild.LeftChild = new Node<string>("35");
      myTree.Root.RightChild.RightChild = new Node<string>("70");

      myTree.Root.LeftChild.LeftChild.LeftChild = new Node<string>("4");
      myTree.Root.LeftChild.LeftChild.RightChild = new Node<string>("12");
      myTree.Root.LeftChild.RightChild.LeftChild = new Node<string>("18");
      myTree.Root.LeftChild.RightChild.RightChild = new Node<string>("24");
      myTree.Root.RightChild.LeftChild.LeftChild = new Node<string>("31");
      myTree.Root.RightChild.LeftChild.RightChild = new Node<string>("44");
      myTree.Root.RightChild.RightChild.LeftChild = new Node<string>("66");
      myTree.Root.RightChild.RightChild.RightChild = new Node<string>("90");

    }
  }
}
