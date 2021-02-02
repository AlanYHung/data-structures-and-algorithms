using System;
using System.Collections.Generic;
using tree;
using tree.binarytree.classes;
using Xunit;

namespace TreeTesting
{
  public class TreeTesting
  {
    static BinaryTree<string> myTree = new BinaryTree<string>();
    static BinarySearchTree<int> myBST = new BinarySearchTree<int>();

    [Fact]
    public void BinaryTreePreOrderTraversalTest()
    {
      myTree = Program.myTree;
      Program.PopulateBinaryTree();
      List<string> expected = new List<string>() { "25", "15", "10", "4", "12", "22", "18", "24", "50", "35", "31", "44", "70", "66", "90" };
      Assert.Equal(expected, myTree.PreOrder(myTree.Root, new List<string>()));
    }

    [Fact]
    public void BinaryTreeInOrderTraversalTest()
    {
      myTree = Program.myTree;
      Program.PopulateBinaryTree();
      List<string> expected = new List<string>() { "4", "10", "12", "15", "18", "22", "24", "25", "31", "35", "44", "50", "66", "70", "90" };
      Assert.Equal(expected, myTree.InOrder(myTree.Root, new List<string>()));
    }

    [Fact]
    public void BinaryTreePostOrderTraversalTest()
    {
      myTree = Program.myTree;
      Program.PopulateBinaryTree();
      List<string> expected = new List<string>() { "4", "12", "10", "18", "24", "22", "15", "31", "44", "35", "66", "90", "70", "50", "25" };
      Assert.Equal(expected, myTree.PostOrder(myTree.Root, new List<string>()));
    }

    [Fact]
    public void EmptyBinaryTreePreOrderTraversalTest()
    {
      myTree = new BinaryTree<string>();
      Assert.Equal(new List<string>(), myTree.PreOrder(myTree.Root, new List<string>()));
    }

    [Fact]
    public void EmptyBinaryTreeInOrderTraversalTest()
    {
      myTree = new BinaryTree<string>();
      Assert.Equal(new List<string>(), myTree.InOrder(myTree.Root, new List<string>()));
    }

    [Fact]
    public void EmptyBinaryTreePostOrderTraversalTest()
    {
      myTree = new BinaryTree<string>();
      Assert.Equal(new List<string>(), myTree.PostOrder(myTree.Root, new List<string>()));
    }

    [Fact]
    public void BinarySearchTreeAddTest()
    {
      myBST = Program.myBST;
      Program.PopulateBinarySearchTree();
      List<int> expected = new List<int>() { 25, 15, 10, 4, 12, 22, 18, 24, 50, 35, 31, 44, 70, 66, 90 };
      Assert.Equal(expected, myBST.PreOrder(myBST.Root, new List<int>()));
    }

    [Fact]
    public void EmptyBinarySearchTreeAddTest()
    {
      myBST = new BinarySearchTree<int>();
      myBST.Add(myBST.Root, 1);
      List<int> expected = new List<int>() { 1 };
      Assert.Equal(expected, myBST.PreOrder(myBST.Root, new List<int>()));
    }

    [Fact]
    public void BinarySearchTreeContainsTest()
    {
      myBST = Program.myBST;
      Program.PopulateBinarySearchTree();
      Assert.True(myBST.Contains(90));
    }

    [Fact]
    public void BinarySearchTreeDoesNotContainTest()
    {
      myBST = Program.myBST;
      Program.PopulateBinarySearchTree();
      Assert.False(myBST.Contains(1));
    }

    [Fact]
    public void EmptyBinarySearchTreeContainsTest()
    {
      myBST = new BinarySearchTree<int>();
      Assert.Throws<NullReferenceException>(() => myBST.Contains(1));
    }

    [Fact]
    public void EmptyBinarySearchTreeFindMaxValueTest()
    {
      myBST = new BinarySearchTree<int>();
      Assert.Throws<NullReferenceException>(() => myBST.FindMaximumValue());
    }

    [Fact]
    public void BinaryTreeFindMaxValueTest()
    {
      myTree = Program.myTree;
      Program.PopulateBinaryTree();
      Assert.Equal("90", myTree.FindMaximumValue());
    }
  }
}
