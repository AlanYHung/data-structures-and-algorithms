using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HashTable.Classes
{
  public class HashMap
  {
    private LinkedList<KeyValuePair<string, string>>[] Map { get; set; }

    public HashMap(int size)
    {
      Map = new LinkedList<KeyValuePair<string, string>>[size];
    }

    /// <summary>
    /// This converts the key into a position on the Hash Map
    /// </summary>
    /// <param name="key">The Key of the Key Value Pair</param>
    /// <returns>index of hashmap to store Key Value Pair</returns>
    private int Hash(string key)
    {
      if(key.Equals(""))
      {
        return -1;
      }

      int hashValue = 0;
      char[] letters = key.ToCharArray();

      for(int i = 0; i < letters.Length; i++)
      {
        hashValue += letters[i];
      }

      hashValue = (hashValue * 599) % Map.Length;
      return hashValue;
    }

    /// <summary>
    /// This adds the Key Value Pair into the hash map
    /// </summary>
    /// <param name="key">The Key</param>
    /// <param name="value">The Value</param>
    public void Add(string key, string value)
    {
      int hashKey = Hash(key);

      if(hashKey > -1)
      {
        if (Map[hashKey] == null)
        {
          Map[hashKey] = new LinkedList<KeyValuePair<string, string>>();
        }

        KeyValuePair<string, string> entry = new KeyValuePair<string, string>(key, value);
        Map[hashKey].AddFirst(entry);
      }
    }

    /// <summary>
    /// This returns the value of the key value pair from within the hash map
    /// </summary>
    /// <param name="key">The key used to determine position in map</param>
    /// <returns>the value of the pair</returns>
    public string Get(string key)
    {
      int hashKey = Hash(key);

      if (Map != null && hashKey > -1)
      {
        if (Map[hashKey] != null)
        {
          LinkedListNode<KeyValuePair<string, string>> current = Map[hashKey].First;

          while (current != null)
          {
            if (current.Value.Key.Equals(key))
            {
              return current.Value.Value;
            }

            current = current.Next;
          }
        }
      }

      return null;
    }

    /// <summary>
    /// This checks if a key value pair is already existing within the map
    /// </summary>
    /// <param name="key">the key of the pair</param>
    /// <returns>true for found and false for not found</returns>
    public bool Contains(string key)
    {
      int hashKey = Hash(key);

      if(Map != null && hashKey > -1)
      {
        if(Map[hashKey] != null)
        {
          LinkedListNode<KeyValuePair<string, string>> current = Map[hashKey].First;

          while(current != null)
          {
            if (current.Value.Key.Equals(key))
            {
              return true;
            }

            current = current.Next;
          }
        }
      }

      return false;
    }

    /// <summary>
    /// This prints the Hash map in a user friendly text format
    /// </summary>
    public void Print()
    {
      for(int i = 0; i < Map.Length; i++)
      {
        if(Map[i] != null)
        {
          Console.Write($"Bucket {i}: ");
          LinkedListNode<KeyValuePair<string, string>> current = Map[i].First;

          while(current != null)
          {
            Console.Write($"[{current.Value.Key} : {current.Value.Value}] => ");
            current = current.Next;
          }

          Console.WriteLine("Null");
        }
      }
    }

    /// <summary>
    /// This looks for the first repeated word in a inputted string
    /// </summary>
    /// <param name="inputString">the string to check</param>
    /// <returns>first repeated word in inputString</returns>
    public string FirstRepeatedWord(string inputString)
    {
      if(inputString.Length > 2)
      {
        inputString = inputString.ToLower();
        string[] splitString = inputString.Split(" ");

        if(splitString.Length > 1)
        {
          for(int i = 0; i < splitString.Length; i++)
          {
            splitString[i] = Regex.Replace(splitString[i], @"[\W*]", "");

            if(Contains(splitString[i]))
            {
              return splitString[i];
            }

            Add(splitString[i], splitString[i]);
          }
        }
      }

      return null;
    }

    /// <summary>
    /// Mimics a SQL LeftJoin Operation
    /// </summary>
    /// <param name="rightTable">the table data to join to the left table</param>
    /// <returns>resulting list from left + right table data</returns>
    public List<KeyValuePair<string, List<string>>> LeftJoin(HashMap rightTable)
    {
      List<KeyValuePair<string, List<string>>> output = new List<KeyValuePair<string, List<string>>>();

      for (int i = 0; i < Map.Length; i++)
      {
        if (Map[i] != null)
        {
          LinkedListNode<KeyValuePair<string, string>> current = Map[i].First;
          string key = current.Value.Key;
          List<string> value = new List<string>()
          {
            current.Value.Value
          };
          KeyValuePair<string, List<string>> keyvalue = new KeyValuePair<string, List<string>>(key, value);

          while (current != null)
          {
            if (rightTable.Contains(current.Value.Key))
            {
              value.Add(rightTable.Get(current.Value.Key));
            }
            else
            {
              value.Add("NULL");
            }

            keyvalue = new KeyValuePair<string, List<string>>(key, value);
            current = current.Next;
          }

          output.Add(keyvalue);
        }
      }

      return output;
    }
  }// end of class
}// end of namespace
