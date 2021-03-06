using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class LinkedList<T>
  {
    public Node<T> Head { get; set; }

    // If using a Method from LinkedList class to add then do not increment this variable
    // Manually adding items to the LinkedList is not recommended
    ////// Need to increment this variable whenever you manually add a Node to the list
    public int Length { get; set; }

    // Constructor
    public LinkedList()
    {
      Length = 0;
      // Initialize Empty List
    }

    // Add items to the beginning of the linked list
    public void Insert(T nodeVal)
    {
      Node<T> newNode = new Node<T>(nodeVal);
      newNode.Next = Head;
      Head = newNode;
      Length++;
    }

    // Checks to see if a value exists in the list.  (Case Sensitive)
    public bool Includes(T nodeVal)
    {
      Node<T> current = Head;
      
      while (current != null)
      {
        if (current.Value.Equals(nodeVal))
        {
          return true;
        }

        current = current.Next;
      }

      return false;
    }

    // Displays all the items in the List
    public override string ToString()
    {
      Node<T> current = Head;
      char openBrace = '{';
      char closeBrace = '}';
      string returnString = "";

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
    public void Append(T insertValue)
    {
      Node<T> current = Head;
      Node<T> insertNode = new Node<T>(insertValue);

      if(current == null)
      {
        Head = insertNode;
        Length++;
      }
      else
      {
        while(current != null)
        {
          if(current.Next == null)
          {
            current.Next = insertNode;
            Length++;
            break;
          }

          current = current.Next;
        }
      }
    }

    // Insert a new item into the list before an existing chosen value
    public void InsertBefore(T value, T newValue)
    {
      Node<T> current = Head;
      Node<T> insertNode = new Node<T>(newValue);

      if(current == null)
      {
        throw new Exception("List is Empty.  New Node not added to list.");
      }
      else if(current.Value.Equals(value))
      {
        insertNode.Next = current;
        Head = insertNode;
        Length++;
      }
      else
      {
        while(current != null)
        {
          if (current.Next == null)
          {
              throw new Exception("Item not found.  New Node not added to list.");
          }

          if (current.Next.Value.Equals(value))
          {
            insertNode.Next = current.Next;
            current.Next = insertNode;
            Length++;
            break;
          }

          current = current.Next;
        }
      }
    }

    // Insert a new item into the list after an existing chosen value
    public void InsertAfter(T value, T newValue)
    {
      Node<T> current = Head;
      Node<T> insertNode = new Node<T>(newValue);
      bool found = false;

      if (current == null)
      {
        throw new Exception("List is Empty.  New Node not added to list.");
      }
      else
      {
        while (current != null)
        {
          if (current.Value.Equals(value))
          {
            insertNode.Next = current.Next;
            current.Next = insertNode;
            found = true;
            Length++;
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

    // Returns the value from the list that is the kth number from the end of the list.
    // Example if function receives 3 from a 5 Length list, it will return the 2nd item in the list. ( 5 - 3 ) = 2
    public T KthFromEnd(int k)
    {
      int positionInList = Length - k - 1;
      Node<T> current = Head;

      if (k > -1 && Head != null && Length >= k)
      {
        for(int i = 0; i < positionInList; i++)
        {
          current = current.Next;
        }

        return current.Value;
      }
      else
      {
        throw new IndexOutOfRangeException("The value given was greater than the Length of the List or less than zero, or the list is empty.");
      }
    }

    // Merges 2 Linked Lists by adding them via alternating nodes from each list
    public Node<T> ZipLists(LinkedList<T> listA, LinkedList<T> listB)
    {
      Node<T> listACurrent = listA.Head;
      Node<T> listBCurrent = listB.Head;
      Node<T> listANextCurrent = listA.Head;

      while(listANextCurrent != null || listBCurrent != null)
      {
        listANextCurrent = listA.Head.Next;
        if (listANextCurrent == null && listBCurrent != null)
        {
          listACurrent.Next = listBCurrent;
          break;
        }

        if (listANextCurrent != null && listBCurrent == null)
        {
          listACurrent.Next = listACurrent;
          break;
        }

        listACurrent.Next = listBCurrent;
        listBCurrent = listBCurrent.Next;
        listACurrent = listACurrent.Next;

        listACurrent.Next = listANextCurrent;
        listANextCurrent = listANextCurrent.Next;
        listACurrent = listACurrent.Next;
      }

      return listA.Head;
    }

    // Removes a node from the Linked List
    public void Delete(int position)
    {
      Node<T> current = Head;
      Node<T> previous = current;

      if (position == 0)
      {
        Head = current.Next;
        current.Next = null;
        Length--;
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
        Length--;
      }
    }
  }
}

