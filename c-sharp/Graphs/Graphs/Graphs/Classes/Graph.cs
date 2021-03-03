using System;
using System.Collections.Generic;

namespace Graphs.Classes
{
  public class Graph<T>
  {
    public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }
    private int size { get; set; }

    /// <summary>
    /// Class Constructor that instantiates the AdjacencyList and sets initial size to 0
    /// </summary>
    public Graph()
    {
      AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
      size = 0;
    }

    /// <summary>
    /// Adds a new Node to graph
    /// </summary>
    /// <param name="value">value to add to graph</param>
    /// <returns>newly created node containing value</returns>
    public Vertex<T> AddNode(T value)
    {
      Vertex<T> node = new Vertex<T>(value);
      AdjacencyList.Add(node, new List<Edge<T>>());
      size++;

      return node;
    }

    /// <summary>
    /// Adds a single direction relationship between 2 nodes
    /// </summary>
    /// <param name="a">Node A</param>
    /// <param name="b">Node B</param>
    public void AddDirectedEdge(Vertex<T> a, Vertex<T> b)
    {
      AdjacencyList[a].Add(
        new Edge<T>
        {
          Weight = 0,
          Vertex = b
        });
    }

    /// <summary>
    /// Adds a bidirectional relationship between 2 nodes
    /// </summary>
    /// <param name="a">Node A</param>
    /// <param name="b">Node B</param>
    public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b)
    {
      AddDirectedEdge(a, b);
      AddDirectedEdge(b, a);
    }

    /// <summary>
    /// Gets the list of neighbors for a specified Node
    /// </summary>
    /// <param name="home">Starting Node</param>
    /// <returns>home Node's Adjacency List</returns>
    public List<Edge<T>> GetNeighbors(Vertex<T> home) =>
        AdjacencyList[home];

    /// <summary>
    /// Prints all the Nodes in the Graph with their Neighbors
    /// </summary>
    public void PrintGraph()
    {
      foreach (var item in AdjacencyList)
      {
        Console.Write($"{item.Key.Value}: ");
        foreach (var edge in item.Value)
        {
          Console.Write($"{edge.Vertex.Value} -> ");
        }
        Console.WriteLine("");
      }
    }

    /// <summary>
    /// Returns the number of nodes in a Graph
    /// </summary>
    /// <returns>size property</returns>
    public int Size() => size;

    /// <summary>
    /// Returns a list of all the nodes in the Graph
    /// </summary>
    /// <returns>a List of Vertices</returns>
    public List<Vertex<T>> GetNodes()
    {
      List<Vertex<T>> nodeList = new List<Vertex<T>>();

      foreach (Vertex<T> node in AdjacencyList.Keys)
      {
        nodeList.Add(node);
      }

      return nodeList;
    }
  }//end of Class
}//end of Namespace
