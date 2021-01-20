using System;
using Xunit;
using DataStructures;
using System.IO;

namespace LinkedListTests
{
  public class UnitTest1
  {
    Node node1 = new Node("Hello");
    Node node2 = new Node("World");
    Node node3 = new Node("!!!!");

    [Fact]
    public void LinkedListInitializationTest()
    {
      // Tests that the linked list can be successfully initialized
      LinkedList testLinkedList = new LinkedList();
      Assert.True(testLinkedList.Head == null);
    }

    [Fact]
    public void InsertTest()
    {
      // Tests that the insert function adds values to beginning of the list
      Program.myLinkedList.Head = node1;
      Program.myLinkedList.Insert("Test");
      Assert.Equal("Test", Program.myLinkedList.Head.Value);
    }

    [Fact]
    public void CheckHeadIsAlwaysFirstNodeTest()
    {
      // Tests to make sure Head always points to first item in list
      Program.myLinkedList.Head = node1;
      node1.Next = node2;
      node2.Next = node3;

      Assert.Equal("Hello", Program.myLinkedList.Head.Value);
    }

    [Fact]
    public void MultipleInsertTest()
    {
      // Tests that insert always adds to the front of the list
      Program.myLinkedList.Insert("Test1");
      Program.myLinkedList.Insert("Test2");
      Program.myLinkedList.Insert("Test3");

      Assert.Equal("Test3", Program.myLinkedList.Head.Value);
      Assert.Equal("Test2", Program.myLinkedList.Head.Next.Value);
      Assert.Equal("Test1", Program.myLinkedList.Head.Next.Next.Value);
      Assert.Null(Program.myLinkedList.Head.Next.Next.Next);
    }

    [Fact]
    public void IncludesFoundTest()
    {
      LinkedList includesTest = new LinkedList();
      includesTest.Head = node1;
      // Tests that the includes method finds items correctly
      Assert.True(includesTest.Includes("Hello"));
    }

    [Fact]
    public void IncludesNotFoundTest()
    {
      LinkedList includesTest = new LinkedList();
      includesTest.Head = node1;
      // Tests that the includes method deals with not found items correctly
      Assert.False(Program.myLinkedList.Includes("Boy"));
    }

    [Fact]
    public void ToStringDisplayTest()
    {
      // Tests that the ToString method returns the correct output
      Program.myLinkedList.Head = node1;
      string check = "{ Hello } -> NULL";
      Assert.Equal(check, Program.myLinkedList.ToString());
    }

    [Fact]
    public void AppendAddsToTheEndTest()
    {
      // Tests that the append method correctly adds items to the end of the list
      LinkedList testLinkedList = new LinkedList();
      testLinkedList.Head = node1;
      node1.Next = node2;
      node2.Next = node3;
      Node current = testLinkedList.Head;
      testLinkedList.Append("7");

      while(current.Next != null)
      {
        current = current.Next;
      }

      Assert.Equal("7", current.Value);
    }

    [Fact]
    public void AddToListBeforePosition()
    {
      // Tests that the list correctly adds to the list before chosen list item
      LinkedList testLinkedList = new LinkedList();
      testLinkedList.Head = node1;
      node1.Next = node2;
      node2.Next = node3;
      testLinkedList.InsertBefore("Hello", "7");
      Assert.Equal("7", testLinkedList.Head.Value);
    }

    [Fact]
    public void AddToListAfterPosition()
    {
      // Tests that the list correctly adds to the list after chosen list item
      LinkedList testLinkedList = new LinkedList();
      testLinkedList.Head = node1;
      node1.Next = node2;
      node2.Next = node3;
      testLinkedList.InsertAfter("Hello", "7");
      Assert.Equal("7", testLinkedList.Head.Next.Value);
    }

    [Fact]
    public void LinkedListLengthTrackingTest()
    {
      // Tests that the Length tracks correctly when Nodes are added
      LinkedList testLinkedList = new LinkedList();
      testLinkedList.Append("10");
      testLinkedList.Insert("1");
      testLinkedList.InsertBefore("10", "3");
      testLinkedList.InsertAfter("3", "6");
      Assert.Equal(4, testLinkedList.Length);
    }

    [Fact]
    public void LinkedListKthFromEndTest()
    {
      LinkedList testLinkedList = new LinkedList();
      testLinkedList.Append("10");
      testLinkedList.Insert("1");
      testLinkedList.InsertBefore("10", "3");
      testLinkedList.InsertAfter("3", "6");
      Assert.Equal("3", testLinkedList.KthFromEnd(2));
    }
  }
}
