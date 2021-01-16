using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class Node
  {
    public string Value { get; set; }
    public Node Next { get; set; }

    // Constructor
    public Node(string nodeVal)
    {
      Value = nodeVal;
      Next = null;
    }
  }
}
