using System;
using System.Collections.Generic;
using System.Text;

namespace tree.karytree.classes
{
  class KaryTree<T>
  {
    public Node<T> Root { get; set; }
    public int MaxChildren { get; set; }

    public KaryTree(int maxChildren)
    {
      Root = null;
      MaxChildren = maxChildren;
    }

    public KaryTree(T value, int maxChildren)
    {
      Root.Value = value;
      MaxChildren = maxChildren;
    }

    public KaryTree<int> FizzBuzzTree(KaryTree<int> kTree)
    {
      if(kTree == null)
      {
        throw new NullReferenceException("K-ary tree is null");
      }
      else
      {
        Queue<Node<int>> nodeQTraverse = new Queue<Node<int>>();
        Queue<Node<string>> newNodeQTree = new Queue<Node<string>>();
        Queue<int> childrenQ = new Queue<int>();
        Queue<int> newTreeChildren = new Queue<int>();
        KaryTree<string> newTree = new KaryTree<string>(kTree.MaxChildren);
        Node<int> current = new Node<int>();
        int numOfChild = kTree.Root.Children.Count;

        nodeQTraverse.Enqueue(kTree.Root);
        childrenQ.Enqueue(numOfChild);

        do
        {
          current = nodeQTraverse.Dequeue();
          numOfChild = childrenQ.Dequeue();

          if(current.Value % 15 == 0)
          {

          }
        } while (nodeQTraverse.Count > 0);
        return null;
      }
    }
  } // end of class
} // end of namespace
