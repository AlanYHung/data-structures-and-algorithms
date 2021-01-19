using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class LinkedList
  {
    public Node Head { get; set; }

    // Constructor
    public LinkedList()
    {
      // Empty Linked List
    }

    // Add items to the beginning of the linked list
    public void insert(string nodeVal)
    {
      Node newNode = new Node(nodeVal);
      newNode.Next = Head;
      Head = newNode;
    }

    // Checks to see if a value exists in the list.  (Case Sensitive)
    public bool includes(string nodeVal)
    {
      Node current = Head;

      while (current != null)
      {
        if (current.Value == nodeVal)
        {
          return true;
        }

        current = current.Next;
      }

      return false;
    }

    // Displays all the items in the List
    public string toString()
    {
      Node current = Head;
      char openBrace = '{';
      char closeBrace = '}';
      string returnString = "";
      Console.Clear();

      while (current != null)
      {
        if (current.Next == null)
        {
          returnString += $"{openBrace} {current.Value} {closeBrace} -> NULL";
        }
        else
        {
          returnString += $"{openBrace} {current.Value} {closeBrace} -> ";
        }

        current = current.Next;
      }

      return returnString;
    }

    // Add a new Node to the end of the list
    public void append(string insertValue)
    {
      Node current = Head;
      Node insertNode = new Node(insertValue);

      while(current != null)
      {
        if(current.Next == null)
        {
          current.Next = insertNode;
          break;
        }

        current = current.Next;
      }
    }

    // Insert a new item into the list before an existing chosen value
    public void insertBefore(string value, string newValue)
    {
      Node current = Head;
      Node insertNode = new Node(newValue);

      if(current == null)
      {
        throw new Exception("List is Empty.  New Node not added to list.");
      }
      else if(current.Value == value)
      {
        insertNode.Next = current;
        Head = insertNode;
      }
      else
      {
        while(current != null)
        {
          if (current.Next == null)
          {
              throw new Exception("Item not found.  New Node not added to list.");
          }

          if (current.Next.Value == value)
          {
            insertNode.Next = current.Next;
            current.Next = insertNode;
            break;
          }

          current = current.Next;
        }
      }
    }

    // Insert a new item into the list after an existing chosen value
    public void insertAfter(string value, string newValue)
    {
      Node current = Head;
      Node insertNode = new Node(newValue);
      bool found = false;

      if (current == null)
      {
        Head = insertNode;
      }
      else
      {
        while (current != null)
        {
          if (current.Value == value)
          {
            insertNode.Next = current.Next;
            current.Next = insertNode;
            found = true;
            break;
          }

          current = current.Next;
        }

        if (!found)
        {
          throw new Exception("Item not found.  New Node not added to list.");
        }
      }
    }

    // Removes a node from the Linked List
    public void delete(int position)
    {
      Node current = Head;
      Node previous = current;

      if (position == 0)
      {
        Head = current.Next;
        current.Next = null;
      }
      else
      {
        for (int i = 0; i < position; i++)
        {
          previous = current;
          current = current.Next;
        }

        previous.Next = current.Next;
        current.Next = null;
      }
    }
  }
}

