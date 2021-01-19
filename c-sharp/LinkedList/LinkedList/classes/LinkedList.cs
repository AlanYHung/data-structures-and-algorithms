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

    public void insertBefore(string value, string newValue)
    {
      Node current = Head;
      Node insertNode = new Node(newValue);

      if(current == null)
      {
        Head = insertNode;
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
  }
}
