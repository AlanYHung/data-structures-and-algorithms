using Graphs;
using Graphs.Classes;
using System;
using Xunit;

namespace GraphTest
{
  public class UnitTest1
  {
    /// <summary>
    /// Tests that a Graph initializes correctly using size property
    /// </summary>
    [Fact]
    public void TestGraphInitializesCorrectly()
    {
      Graph<int> newGraph = new Graph<int>();
      Assert.Equal(0, Program.graph.Size());
    }

    /// <summary>
    /// Tests that Size is incremented and can be retrieved correctly
    /// </summary>
    [Fact]
    public void TestSizeIncrementsAndRetrievesCorrectly()
    {
      Program.PopulateGraph();
      Assert.Equal(7, Program.graph.Size());
    }
  }
}
