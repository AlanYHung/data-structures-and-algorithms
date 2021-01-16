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
    public void Test1()
    {
      LinkedList testLinkedList = new LinkedList();

      Assert.True(testLinkedList.Head == null);
    }

    [Fact]
    public void Test2()
    {
      Program.myLinkedList.Head = node1;
      Program.insert("Test");
      Assert.Equal("Test", Program.myLinkedList.Head.Value);
    }

    [Fact]
    public void Test3()
    {
      Program.myLinkedList.Head = node1;
      node1.Next = node2;
      node2.Next = node3;

      Assert.Equal("Hello", Program.myLinkedList.Head.Value);
    }

    [Fact]
    public void Test4()
    {
      Program.insert("Test1");
      Program.insert("Test2");
      Program.insert("Test3");

      Assert.Equal("Test3", Program.myLinkedList.Head.Value);
      Assert.Equal("Test2", Program.myLinkedList.Head.Next.Value);
      Assert.Equal("Test1", Program.myLinkedList.Head.Next.Next.Value);
      Assert.Equal("Test", Program.myLinkedList.Head.Next.Next.Next.Value);
      Assert.Equal("Hello", Program.myLinkedList.Head.Next.Next.Next.Next.Value);
      Assert.Null(Program.myLinkedList.Head.Next.Next.Next.Next.Next);
    }

    [Fact]
    public void Test5()
    {
      Assert.True(Program.includes("Hello"));
    }

    [Fact]
    public void Test6()
    {
      Assert.False(Program.includes("Boy"));
    }

    //[Fact]
    //public void Test7()
    //{
      //Program.myLinkedList.Head = node1;
      //string check = "{ Test3 } -> { Test2 } -> { Test1 } -> { Test } -> { Hello } -> NULL";
      //Assert.Equal(check, Program.toString());
    //}
  }
}
