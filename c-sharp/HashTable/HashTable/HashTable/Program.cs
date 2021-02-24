using HashTable.Classes;
using System;
using System.Collections.Generic;
using tree.binarytree.classes;

namespace HashTable
{
  public class Program
  {
    public static HashMap MyMap;
    public static BinarySearchTree<string> TreeOne = new BinarySearchTree<string>();
    public static BinarySearchTree<string> TreeTwo = new BinarySearchTree<string>();
    public static List<string> CollisionList;

    static void Main(string[] args)
    {
      Populate();
      MyMap.Print();
      Console.WriteLine(MyMap.Get("Elephant"));
      Console.WriteLine(MyMap.Get("Kangaroo"));
      Console.WriteLine(MyMap.Get("Giraffe"));
      Console.WriteLine(MyMap.Get("Iguana"));
      Console.WriteLine(MyMap.Contains("Elephant"));
      Console.WriteLine(MyMap.Contains("Unicorn"));
      Console.WriteLine(MyMap.Contains("Frog"));
      Console.WriteLine(MyMap.Contains("Iguana"));

      MyMap = new HashMap(20);
      Console.WriteLine(MyMap.FirstRepeatedWord("Welcome ???@@##$ to#$% Geeks%$^ for$%^& Geeks"));
      MyMap = new HashMap(20);
      Console.WriteLine(MyMap.FirstRepeatedWord("Once upon a time, there was a brave princess who..."));
      MyMap = new HashMap(20);
      Console.WriteLine(MyMap.FirstRepeatedWord("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only..."));
      MyMap = new HashMap(20);
      Console.WriteLine(MyMap.FirstRepeatedWord("It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York..."));

      PopulateTrees();
      CollisionList = TreeIntersection(TreeOne, TreeTwo, 20);

      Console.Write("[");
      foreach (string value in CollisionList)
      {
        Console.Write(" {0} ", value);
      }
      Console.WriteLine("]");
    }

    public static void Populate()
    {
      MyMap = new HashMap(20);
      MyMap.Add("Cat", "22");
      MyMap.Add("Dog", "50");
      MyMap.Add("Elephant", "112");
      MyMap.Add("Fox", "87");
      MyMap.Add("Giraffe", "95");
      MyMap.Add("Horse", "130");
      MyMap.Add("Iguana", "123");
      MyMap.Add("Kangaroo", "86");
      MyMap.Add("Llama", "73");
      MyMap.Add("Mouse", "111");
      MyMap.Add("Newt", "71");
      MyMap.Add("Octopus", "116");
      MyMap.Add("Snake", "73");
    }

    public static void PopulateTrees()
    {
      TreeOne.Add(TreeOne.Root, "150");
      TreeOne.Add(TreeOne.Root, "100");
      TreeOne.Add(TreeOne.Root, "75");
      TreeOne.Add(TreeOne.Root, "160");
      TreeOne.Add(TreeOne.Root, "125");
      TreeOne.Add(TreeOne.Root, "175");
      TreeOne.Add(TreeOne.Root, "250");
      TreeOne.Add(TreeOne.Root, "200");
      TreeOne.Add(TreeOne.Root, "350");
      TreeOne.Add(TreeOne.Root, "300");
      TreeOne.Add(TreeOne.Root, "500");

      TreeTwo.Add(TreeTwo.Root, "42");
      TreeTwo.Add(TreeTwo.Root, "100");
      TreeTwo.Add(TreeTwo.Root, "15");
      TreeTwo.Add(TreeTwo.Root, "160");
      TreeTwo.Add(TreeTwo.Root, "125");
      TreeTwo.Add(TreeTwo.Root, "175");
      TreeTwo.Add(TreeTwo.Root, "600");
      TreeTwo.Add(TreeTwo.Root, "200");
      TreeTwo.Add(TreeTwo.Root, "350");
      TreeTwo.Add(TreeTwo.Root, "4");
      TreeTwo.Add(TreeTwo.Root, "500");
    }

    /// <summary>
    /// Maps and returns a list of all collisions between 2 binary trees
    /// </summary>
    /// <param name="tree1">input tree to check for collisions</param>
    /// <param name="tree2">input tree to check for collisions</param>
    /// <param name="size">size of Hash Table</param>
    /// <returns>List of all collision nodes or null</returns>
    public static List<string> TreeIntersection(BinaryTree<string> tree1, BinaryTree<string> tree2, int size)
    {
      if(tree1 != null && tree2 != null)
      {
        MyMap = new HashMap(size);

        MyMap = BuildHashTable(MyMap, tree1.Root);
        return BuildCollisionList(MyMap, tree2.Root, new List<string>());
      }

      return null;
    }

    /// <summary>
    /// This table maps all the nodes of the first binary tree into a Hash Table
    /// </summary>
    /// <param name="collisionMap">Hash Table to set up</param>
    /// <param name="current">Node of current position in tree</param>
    /// <returns>reference to Hash Table</returns>
    public static HashMap BuildHashTable(HashMap collisionMap, Node<string> current)
    {
      if(current != null)
      {
        collisionMap.Add(current.Value, current.Value);
        BuildHashTable(collisionMap, current.LeftChild);
        BuildHashTable(collisionMap, current.RightChild);
      }

      return collisionMap;
    }

    /// <summary>
    /// This method traverses through the 2nd list and adds all collisions to a list
    /// </summary>
    /// <param name="collisionMap">Hash Table storing the values of the first tree</param>
    /// <param name="current">current position in 2nd tree during traverse</param>
    /// <param name="collisionList">List of collisions</param>
    /// <returns>List of collisions</returns>
    public static List<string> BuildCollisionList(HashMap collisionMap, Node<string> current, List<string> collisionList)
    {
      if(current != null)
      {
        if (collisionMap.Contains(current.Value))
        {
          collisionList.Add(current.Value);
        }

        BuildCollisionList(collisionMap, current.LeftChild, collisionList);
        BuildCollisionList(collisionMap, current.RightChild, collisionList);
      }

      return collisionList;
    }
  }//end of class
}//end of namespace
