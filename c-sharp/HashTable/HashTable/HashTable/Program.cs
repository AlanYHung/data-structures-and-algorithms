using HashTable.Classes;
using System;

namespace HashTable
{
  public class Program
  {
    public static HashMap MyMap;

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
  }
}
