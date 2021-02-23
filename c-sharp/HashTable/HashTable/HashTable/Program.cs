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

      MyMap = new HashMap(20);
      Console.WriteLine(MyMap.FirstRepeatedWord("Welcome ???@@##$ to#$% Geeks%$^ for$%^& Geeks"));
      MyMap = new HashMap(20);
      Console.WriteLine(MyMap.FirstRepeatedWord("Once upon a time, there was a brave princess who..."));
      MyMap = new HashMap(20);
      Console.WriteLine(MyMap.FirstRepeatedWord("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only..."));
      MyMap = new HashMap(20);
      Console.WriteLine(MyMap.FirstRepeatedWord("It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York..."));
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
