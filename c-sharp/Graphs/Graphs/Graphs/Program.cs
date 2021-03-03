using Graphs.Classes;
using System;

namespace Graphs
{
  public class Program
  {
    public static Graph<int> graph = new Graph<int>();

    static void Main(string[] args)
    {
      PopulateGraph();
      graph.PrintGraph();
    }

    /// <summary>
    /// Creates a Connected Cyclic Graph for Testing purposes
    /// </summary>
    public static void PopulateGraph()
    {
      Vertex<int> nodeA = graph.AddNode(5);
      Vertex<int> nodeB = graph.AddNode(10);
      graph.AddUndirectedEdge(nodeA, nodeB);
      nodeA = graph.AddNode(7);
      graph.AddUndirectedEdge(nodeA, nodeB);
      nodeB = graph.AddNode(14);
      nodeA = graph.AddNode(-1);
      graph.AddUndirectedEdge(nodeA, nodeB);
      nodeB = graph.AddNode(1);
      graph.AddUndirectedEdge(nodeA, nodeB);
      nodeB = graph.AddNode(17);
      graph.AddUndirectedEdge(nodeA, nodeB);
    }
  }
}
