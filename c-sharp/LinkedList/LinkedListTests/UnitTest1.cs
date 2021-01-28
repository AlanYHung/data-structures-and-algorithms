using System;
using Xunit;
using DataStructures;
using System.IO;

namespace LinkedListTests
{
  public class UnitTest1
  {
    Node<string> node1 = new Node<string>("Hello");
    Node<string> node2 = new Node<string>("World");
    Node<string> node3 = new Node<string>("!!!!");

    [Fact]
    public void LinkedListInitializationTest()
    {
      // Tests that the linked list can be successfully initialized
      LinkedList<string> testLinkedList = new LinkedList<string>();
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
      LinkedList<string> includesTest = new LinkedList<string>();
      includesTest.Head = node1;
      // Tests that the includes method finds items correctly
      Assert.True(includesTest.Includes("Hello"));
    }

    [Fact]
    public void IncludesNotFoundTest()
    {
      LinkedList<string> includesTest = new LinkedList<string>();
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
      LinkedList<string> testLinkedList = new LinkedList<string>();
      testLinkedList.Head = node1;
      node1.Next = node2;
      node2.Next = node3;
      Node<string> current = testLinkedList.Head;
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
      LinkedList<string> testLinkedList = new LinkedList<string>();
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
      LinkedList<string> testLinkedList = new LinkedList<string>();
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
      LinkedList<string> testLinkedList = new LinkedList<string>();
      testLinkedList.Append("10");
      testLinkedList.Insert("1");
      testLinkedList.InsertBefore("10", "3");
      testLinkedList.InsertAfter("3", "6");
      Assert.Equal(4, testLinkedList.Length);
    }

    [Fact]
    public void LinkedListKthFromEndTest()
    {
      LinkedList<string> testLinkedList = new LinkedList<string>();
      testLinkedList.Append("10");
      testLinkedList.Insert("1");
      testLinkedList.InsertBefore("10", "3");
      testLinkedList.InsertAfter("3", "6");
      Assert.Equal("3", testLinkedList.KthFromEnd(2));
    }

    [Theory]
    [InlineData(10)]
    //[InlineData(4)]
    [InlineData(-1)]
    public void KthFromEndIndexOutOfRangeTest(int k)
    {
      LinkedList<string> testLinkedList = new LinkedList<string>();
      testLinkedList.Append("10");
      testLinkedList.Insert("1");
      testLinkedList.InsertBefore("10", "3");
      testLinkedList.InsertAfter("3", "6");
      Assert.Throws<IndexOutOfRangeException>(() => testLinkedList.KthFromEnd(k));
    }

    [Fact]
    public void LinkedListKthFromEndSizeOfOneTest()
    {
      LinkedList<string> testLinkedList = new LinkedList<string>();
      testLinkedList.Append("10");
      Assert.Equal("10", testLinkedList.KthFromEnd(1));
    }

    //[Fact]
    //public void ZipSameSizeListsTest()
    //{
    //  LinkedList<string> testLinkedListA = new LinkedList<string>();
    //  testLinkedListA.Append("10");
    //  testLinkedListA.Insert("1");
    //  testLinkedListA.InsertBefore("10", "3");
    //  testLinkedListA.InsertAfter("3", "6");
    //  LinkedList<string> testLinkedListB = new LinkedList<string>();
    //  testLinkedListB.Append("10");
    //  testLinkedListB.Insert("1");
    //  testLinkedListB.InsertBefore("10", "3");
    //  testLinkedListB.InsertAfter("3", "6");
    //  string outputString = "{ 1 } -> { 1 } -> { 3 } -> { 3 } -> { 6 } -> { 6 } -> { 10 } -> { 10 } -> NULL";
    //  testLinkedListA.Head = testLinkedListA.ZipLists(testLinkedListA, testLinkedListB);
    //  Assert.Equal(outputString, testLinkedListA.ToString());
    //}

    [Fact]
    public void ZipSameTwoNullTest()
    {
      LinkedList<string> testLinkedListA = new LinkedList<string>();
      LinkedList<string> testLinkedListB = new LinkedList<string>();
      Assert.Null(testLinkedListA.ZipLists(testLinkedListA, testLinkedListB));
    }

    [Fact]
    public void AddingToStackTest()
    {
      Stack<int> newStack = new Stack<int>();
      newStack.Push(1);
      Assert.True(newStack.top != null);
    }

    [Fact]
    public void RemovingFromStackTest()
    {
      Stack<int> newStack = new Stack<int>();
      newStack.Push(1);
      Assert.True(newStack.Pop().Value == 1);
    }

    [Fact]
    public void PeekingatStackTest()
    {
      Stack<int> newStack = new Stack<int>();
      newStack.Push(1);
      Assert.True(newStack.peek() == 1);
    }

    [Fact]
    public void StackIsEmptyTest()
    {
      Stack<int> newStack = new Stack<int>();
      Assert.True(newStack.IsEmpty());
    }

    [Fact]
    public void AddingToQueueTest()
    {
      Queue<int> newQueue = new Queue<int>();
      newQueue.Enqueue(1);
      Assert.True(newQueue.front != null);
    }

    [Fact]
    public void RemovingFromQueueTest()
    {
      Queue<int> newQueue = new Queue<int>();
      newQueue.Enqueue(1);
      Assert.True(newQueue.Dequeue().Value == 1);
    }

    [Fact]
    public void PeekatQueueTest()
    {
      Queue<int> newQueue = new Queue<int>();
      newQueue.Enqueue(1);
      Assert.True(newQueue.peek() == 1);
    }

    [Fact]
    public void QueueIsEmptyTest()
    {
      Queue<int> newQueue = new Queue<int>();
      Assert.True(newQueue.IsEmpty());
    }

    [Fact]
    public void QueueWithStackEmptyEnqueueAndDequeueTest()
    {
      PseudoQueue<int> newPseudoQueue = new PseudoQueue<int>();
      newPseudoQueue.enqueue(1);
      Assert.Equal(1, newPseudoQueue.dequeue());
    }

    [Fact]
    public void QueueWithStackEnqueueAndDequeueTest()
    {
      PseudoQueue<int> newPseudoQueue = new PseudoQueue<int>();
      newPseudoQueue.enqueue(1);
      newPseudoQueue.enqueue(2);
      newPseudoQueue.enqueue(3);
      newPseudoQueue.enqueue(4);
      Assert.Equal(1, newPseudoQueue.dequeue());
    }

    [Fact]
    public void QueueWithStackEmptyDequeueTest()
    {
      PseudoQueue<int> newPseudoQueue = new PseudoQueue<int>();
      Assert.Throws<NullReferenceException>(() => newPseudoQueue.dequeue());
    }

    [Fact]
    public void EmptyAnimalShelterEnqueueAndDequeueTest()
    {
      AnimalShelter newShelter = new AnimalShelter();
      newShelter.enqueue((CatDog)0);
      Assert.Equal((CatDog)0, newShelter.dequeue((CatDog)0));
    }

    [Fact]
    public void AnimalShelterEnqueueAndDequeueTest()
    {
      AnimalShelter newShelter = new AnimalShelter();
      newShelter.enqueue((CatDog)0);
      newShelter.enqueue((CatDog)0);
      newShelter.enqueue((CatDog)1);
      newShelter.enqueue((CatDog)0);
      newShelter.enqueue((CatDog)1);
      Assert.Equal((CatDog)0, newShelter.dequeue((CatDog)0));
      Assert.Equal((CatDog)0, newShelter.dequeue((CatDog)0));
    }

    [Theory]
    [InlineData(true, "{}")]
    [InlineData(true, "{}(){}")]
    [InlineData(true, "()[[Extra Characters]]")]
    [InlineData(true, "(){}[[]]")]
    [InlineData(true, "{}{Code}[Fellows](())")]
    [InlineData(false, "[({}]")]
    [InlineData(false, "(](")]
    [InlineData(false, "{(})")]
    public void MultiBracketValidationTest(bool expectedResult, string testInput)
    {
      Assert.Equal(expectedResult, Program.MultiBracketValidation(testInput));
    }

    [Fact]
    public void MultiBracketValidationEmptyStringTest()
    {
      Assert.Throws<Exception>(() => Program.MultiBracketValidation(""));
    }
  }
}
