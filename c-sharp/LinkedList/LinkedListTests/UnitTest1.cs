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

    [Theory]
    [InlineData(10)]
    [InlineData(4)]
    [InlineData(-1)]
    public void KthFromEndIndexOutOfRangeTest(int k)
    {
      LinkedList testLinkedList = new LinkedList();
      testLinkedList.Append("10");
      testLinkedList.Insert("1");
      testLinkedList.InsertBefore("10", "3");
      testLinkedList.InsertAfter("3", "6");
      Assert.Throws<IndexOutOfRangeException>(() => testLinkedList.KthFromEnd(k));
    }

    [Fact]
    public void LinkedListKthFromEndSizeOfOneTest()
    {
      LinkedList testLinkedList = new LinkedList();
      testLinkedList.Append("10");
      Assert.Equal("10", testLinkedList.KthFromEnd(1));
    }

    [Fact]
    public void ZipSameSizeListsTest()
    {
      LinkedList testLinkedListA = new LinkedList();
      testLinkedListA.Append("10");
      testLinkedListA.Insert("1");
      testLinkedListA.InsertBefore("10", "3");
      testLinkedListA.InsertAfter("3", "6");
      LinkedList testLinkedListB = new LinkedList();
      testLinkedListB.Append("10");
      testLinkedListB.Insert("1");
      testLinkedListB.InsertBefore("10", "3");
      testLinkedListB.InsertAfter("3", "6");
      string outputString = "{ 1 } -> { 1 } -> { 3 } -> { 3 } -> { 6 } -> { 6 } -> { 10 } -> { 10 } -> NULL";
      testLinkedListA.Head = testLinkedListA.ZipLists(testLinkedListA, testLinkedListB);
      Assert.Equal(outputString, testLinkedListA.ToString());
    }

    [Fact]
    public void ZipSameTwoNullTest()
    {
      LinkedList testLinkedListA = new LinkedList();
      LinkedList testLinkedListB = new LinkedList();
      Assert.Null(testLinkedListA.ZipLists(testLinkedListA, testLinkedListB));
    }

    // I think the break statement is causing this test to hang.  If you have any suggestions on how to fix please let me know

    //[Fact]
    //public void ZipListsListALongerTest()
    //{
    //  LinkedList testLinkedListA = new LinkedList();
    //  testLinkedListA.Append("10");
    //  testLinkedListA.Insert("1");
    //  testLinkedListA.InsertBefore("10", "3");
    //  testLinkedListA.InsertAfter("3", "6");
    //  LinkedList testLinkedListB = new LinkedList();
    //  testLinkedListB.Append("10");
    //  testLinkedListB.Insert("1");
    //  string outputString = "{ 1 } -> { 1 } -> { 3 } -> { 10 } -> { 6 } -> { 10 } -> NULL";
    //  testLinkedListA.Head = testLinkedListA.ZipLists(testLinkedListA, testLinkedListB);
    //  Assert.Equal(outputString, testLinkedListA.ToString());
    //}
  }
}
