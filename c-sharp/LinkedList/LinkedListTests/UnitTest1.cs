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
      Program.myLinkedList.insert("Test");
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
      Program.myLinkedList.insert("Test1");
      Program.myLinkedList.insert("Test2");
      Program.myLinkedList.insert("Test3");

      Assert.Equal("Test3", Program.myLinkedList.Head.Value);
      Assert.Equal("Test2", Program.myLinkedList.Head.Next.Value);
      Assert.Equal("Test1", Program.myLinkedList.Head.Next.Next.Value);
      Assert.Equal("Test", Program.myLinkedList.Head.Next.Next.Next.Value);
      Assert.Equal("Hello", Program.myLinkedList.Head.Next.Next.Next.Next.Value);
      Assert.Null(Program.myLinkedList.Head.Next.Next.Next.Next.Next);
    }

    [Fact]
    public void IncludesFoundTest()
    {
      // Tests that the includes method finds items correctly
      Assert.True(Program.myLinkedList.includes("Hello"));
    }

    [Fact]
    public void IncludesNotFoundTest()
    {
      // Tests that the includes method deals with not found items correctly
      Assert.False(Program.myLinkedList.includes("Boy"));
    }

    [Fact]
    public void ToStringDisplayTest()
    {
      // Tests that the ToString method returns the correct output
      Program.myLinkedList.Head = node1;
      string check = "{ Hello } -> NULL";
      Assert.Equal(check, Program.myLinkedList.toString());
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
      testLinkedList.append("7");

      while(current.Next != null)
      {
        current = current.Next;
      }

      Assert.Equal("7", current.Value);
    }

    [Fact]
    public void Test9()
    {
      LinkedList testLinkedList = new LinkedList();
      testLinkedList.Head = node1;
      node1.Next = node2;
      node2.Next = node3;
      testLinkedList.insertBefore("Hello", "7");
      Assert.Equal("7", testLinkedList.Head.Value);
    }

    [Fact]
    public void Test10()
    {
      LinkedList testLinkedList = new LinkedList();
      testLinkedList.Head = node1;
      node1.Next = node2;
      node2.Next = node3;
      testLinkedList.insertAfter("Hello", "7");
      Assert.Equal("7", testLinkedList.Head.Next.Value);
    }
  }
}
