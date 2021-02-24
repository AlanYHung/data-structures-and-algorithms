using HashTable;
using HashTable.Classes;
using System;
using Xunit;
using tree.binarytree.classes;

namespace HashTableTests
{
  public class UnitTest1
  {
    /// <summary>
    /// Since To Test Add, We will use Get/Contains to check if the key was added to Hash Map, this test tests Add, Get/Contains, and Hash.  Hash is tested because nothing will work if Hash doesn't work.
    /// </summary>
    [Fact]
    public void TestAddHashAndGetToHashMapHappyPath()
    {
      Program.MyMap = new HashMap(20);
      Program.Populate();

      //Testing Add and Hash
      Program.MyMap.Add("Test", "999");

      //Testing Get and Hash
      Assert.Equal("999", Program.MyMap.Get("Test"));

      //Testing Contains and Hash
      Assert.True(Program.MyMap.Contains("Test"));
    }

    [Fact]
    public void TestAddHashAndGetToHashMapWithEmptyKeyString()
    {
      Program.MyMap = new HashMap(20);
      Program.Populate();

      //Testing Add and Hash
      Program.MyMap.Add("", "999");

      //Testing Get and Hash
      Assert.Null(Program.MyMap.Get(""));

      //Testing Contains and Hash
      Assert.False(Program.MyMap.Contains(""));
    }

    /// <summary>
    /// This tests the Happy Path of the First Repeated Word Function
    /// </summary>
    /// <param name="value">The inputed string</param>
    /// <param name="solution">The expected Result</param>
    [Theory]
    [InlineData("Welcome ???@@##$ to#$% Geeks%$^ for$%^& Geeks", "geeks")]
    [InlineData("Once upon a time, there was a brave princess who...", "a")]
    [InlineData("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...", "it")]
    [InlineData("It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...", "summer")]
    public void TestFirstRepeatedWordHappyPath(string value, string solution)
    {
      Program.MyMap = new HashMap(20);
      Assert.Equal(solution, Program.MyMap.FirstRepeatedWord(value));
    }

    /// <summary>
    /// This tests the Edge Cases of the First Repeated Word Function
    /// </summary>
    /// <param name="value"></param>
    [Theory]
    [InlineData("a")]
    [InlineData("a ")]
    [InlineData("")]
    [InlineData("Hello World, I want to sleep.")]
    public void TestFirstRepeatedWordEdgeCases(string value)
    {
      Program.MyMap = new HashMap(20);
      Assert.Null(Program.MyMap.FirstRepeatedWord(value));
    }

    /// <summary>
    /// This tests that TreeIntersection works
    /// </summary>
    [Fact]
    public void TestTreeIntersectionHappyPath()
    {
      Program.PopulateTrees();
      Program.CollisionList = Program.TreeIntersection(Program.TreeOne, Program.TreeTwo, 20);
      Assert.True(Program.CollisionList.Contains("100"));
      Assert.True(Program.CollisionList.Contains("160"));
      Assert.True(Program.CollisionList.Contains("125"));
      Assert.True(Program.CollisionList.Contains("175"));
      Assert.True(Program.CollisionList.Contains("200"));
      Assert.True(Program.CollisionList.Contains("350"));
      Assert.True(Program.CollisionList.Contains("500"));
    }

    /// <summary>
    /// This tests an Edge Case of Tree Intersection
    /// </summary>
    [Fact]
    public void TestTreeIntersectionWithEmptyTrees()
    {
      Assert.Null(Program.TreeIntersection(null, null, 20));
    }
  }
}
