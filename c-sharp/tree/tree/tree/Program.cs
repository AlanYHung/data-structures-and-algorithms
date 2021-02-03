using System;
using System.Collections.Generic;
using tree.binarytree.classes;

namespace tree
{
  public class Program
  {
    public static BinaryTree<string> myTree = new BinaryTree<string>();
    public static BinarySearchTree<int> myBST = new BinarySearchTree<int>();

    static void Main(string[] args)
    {
      List<string> treeList = new List<string>();
      List<int> bstList = new List<int>();

      PopulateBinaryTree();
      PopulateBinarySearchTree();



      // This Section is for Pre-Order Traverse
      treeList = myTree.PreOrder(myTree.Root, treeList);
      Console.Write("Pre-Order Binary Tree:         ");

      foreach (string value in treeList)
      {
        Console.Write("{0} ", value);
      }

      Console.WriteLine();
      bstList = myBST.PreOrder(myBST.Root, bstList);
      Console.Write("Pre-Order Binary Search Tree:  ");

      foreach (int value in bstList)
      {
        Console.Write("{0} ", value);
      }



      // This Section is for In-Order Traverse
      Console.WriteLine("\n");
      treeList = new List<string>();
      treeList = myTree.InOrder(myTree.Root, treeList);
      Console.Write("In-Order Tree:                ");

      foreach (string value in treeList)
      {
        Console.Write("{0} ", value);
      }

      Console.WriteLine();
      bstList = myBST.InOrder(myBST.Root, new List<int>());
      Console.Write("In-Order Binary Search Tree:  ");

      foreach (int value in bstList)
      {
        Console.Write("{0} ", value);
      }



      // This section is for Post-Order Traverse
      Console.WriteLine("\n");
      treeList = new List<string>();
      treeList = myTree.PostOrder(myTree.Root, treeList);
      Console.Write("Post-Order Tree:                ");

      foreach (string value in treeList)
      {
        Console.Write("{0} ", value);
      }

      Console.WriteLine();
      bstList = myBST.PostOrder(myBST.Root, new List<int>());
      Console.Write("Post-Order Binary Search Tree:  ");

      foreach (int value in bstList)
      {
        Console.Write("{0} ", value);
      }



      // This section is for Breadth First Traverse
      Console.WriteLine("\n");
      treeList = new List<string>();
      treeList = myTree.BreadthFirst();
      Console.Write("Breadth-First Tree:                ");

      foreach (string value in treeList)
      {
        Console.Write("{0} ", value);
      }

      Console.WriteLine();
      bstList = myBST.BreadthFirst();
      Console.Write("Breadth First Binary Search Tree:  ");

      foreach (int value in bstList)
      {
        Console.Write("{0} ", value);
      }



      // This section Tests the BST Contains Method
      Console.WriteLine("\n");
      Console.WriteLine("BST contains 50:  {0}", myBST.Contains(50));
      Console.WriteLine("BST contains 90:  {0}", myBST.Contains(90));
      Console.WriteLine("BST contains 10:  {0}", myBST.Contains(10));
      Console.WriteLine("BST contains 99:  {0}", myBST.Contains(99));
      Console.WriteLine("BST contains 13:  {0}", myBST.Contains(13));
      Console.WriteLine("BST contains 45:  {0}", myBST.Contains(45));



      // This section Tests the BT Max Value Method
      Console.WriteLine("\n");
      Console.WriteLine("Max Value BT: {0}", myTree.FindMaximumValue());
      Console.WriteLine("Max Value BST: {0}", myBST.FindMaximumValue());
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

    public static void PopulateBinarySearchTree()
    {
      myBST.Add(myBST.Root, 25);

      myBST.Add(myBST.Root, 15);
      myBST.Add(myBST.Root, 50);

      myBST.Add(myBST.Root, 10);
      myBST.Add(myBST.Root, 22);
      myBST.Add(myBST.Root, 35);
      myBST.Add(myBST.Root, 70);

      myBST.Add(myBST.Root, 4);
      myBST.Add(myBST.Root, 12);
      myBST.Add(myBST.Root, 18);
      myBST.Add(myBST.Root, 24);
      myBST.Add(myBST.Root, 31);
      myBST.Add(myBST.Root, 44);
      myBST.Add(myBST.Root, 66);
      myBST.Add(myBST.Root, 90);
    }
  }
}
