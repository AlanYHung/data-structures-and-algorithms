using System;

namespace DataStructures
{
  public class Program
  {
    // Global declaration for empty Linked List.
    public static LinkedList myLinkedList = new LinkedList();

    // Control for LinkedList Program
    static void Main(string[] args)
    {
      string userInput;
      populateList();

      do
      {
        Console.Clear();
        userInput = userMenu();

        switch (userInput)
        {
          case "1":
            addToList();
            Console.Clear();
            break;
          case "2":
            removeFromList();
            break;
          case "3":

            if (checkExists())
            {
              Console.WriteLine("Value was found.");
            }
            else
            {
              Console.WriteLine("Value was not found.");
            }

            pauseScreen();
            break;
          case "4":
            Console.WriteLine(toString());
            pauseScreen();
            break;
          case "5":
            Console.WriteLine("Have a nice day!");
            break;
          default:
            Console.WriteLine("Invalid selection.  Please choose a number from 1 to 4.");
            pauseScreen();
            break;
        }
      } while (userInput != "5");
    }

    // Creates a default list
    static void populateList()
    {
      for (int i = 0; i < 3; i++)
      {
        switch (i)
        {
          case 0:
            insert("!!!");
            break;
          case 1:
            insert("World");
            break;
          case 2:
            insert("Hello");
            break;
        }
      }
    }

    // Pause Screen so user can see output
    static void pauseScreen()
    {
      Console.WriteLine("\n\nPlease press Enter to continue...");
      Console.ReadLine();
    }

    // User Menu Options
    static string userMenu()
    {
      string userInput;

      Console.Clear();
      Console.WriteLine("1. Add item to List");
      Console.WriteLine("2. Remove item to List");
      Console.WriteLine("3. Check to see if item is in List");
      Console.WriteLine("4. Display List");
      Console.WriteLine("5. Exit");
      Console.Write("\n\nPlease choose a number (1-5): ");
      userInput = Console.ReadLine();
      Console.Clear();

      return userInput;
    }

    // Add items to the beginning of the linked list
    public static void insert(string nodeVal)
    {
      Node newNode = new Node(nodeVal);
      newNode.Next = myLinkedList.Head;
      myLinkedList.Head = newNode;
    }

    // Gets user input value for insert function
    static void addToList()
    {
      string userInput;

      do
      {
        Console.Write("Add a value to the linked list: ");
        userInput = Console.ReadLine();
        insert(userInput);

        do
        {
          Console.WriteLine("Would you like to add another item? (y/n)");
          userInput = Console.ReadLine().ToLower();

          if (userInput != "n" && userInput != "y")
          {
            Console.WriteLine("Invalid response.  Please choose 'y' or 'n'.");
            pauseScreen();
          }

          Console.Clear();
        } while (userInput != "n" && userInput != "y");
      } while (userInput != "n");
    }

    // Removes a node from the Linked List
    static void delete(int position)
    {
      Node current = myLinkedList.Head;
      Node previous = current;

      if(position == 0)
      {
        myLinkedList.Head = myLinkedList.Head.Next;
      }
      else
      {
        for(int i = 0; i < position; i++)
        {
          previous = current;
          current = current.Next;
        }

        previous.Next = current.Next;
        current.Next = null;
      }
    }

    // Gets user input for removing from Linked List
    static void removeFromList()
    {
      Node current = myLinkedList.Head;
      int nodeCount = 0;
      string userInput;
      int userInputConverted;
      Console.WriteLine("Please choose an item to remove from the list.\n");

      while(current != null)
      {
        Console.WriteLine("{0}. {1}", nodeCount + 1, current.Value);
        nodeCount++;
        current = current.Next;
      }

      if(nodeCount != 0)
      {
        Console.Write("\n\nPlease choose an item to remove (1-{0}): ",nodeCount);
        userInput = Console.ReadLine();

        try
        {
          userInputConverted = Convert.ToInt32(userInput);

          if(userInputConverted < 1 || userInputConverted > nodeCount + 1)
          {
            removeFromList();
          }
          else
          {
            delete(userInputConverted - 1);
          }
        }
        catch (Exception e)
        {
          Console.Clear();
          Console.WriteLine("Please enter a number.");
          pauseScreen();
        }
      }
      else
      {
        Console.Clear();
        Console.WriteLine("List is empty.");
        pauseScreen();
      }
    }

    // Checks to see if a value exists in the list.  (Case Sensitive)
    public static bool includes(string nodeVal)
    {
      Node current = myLinkedList.Head;

      while (current != null)
      {
        if(current.Value == nodeVal)
        {
          return true;
        }

        current = current.Next;
      }

      return false;
    }

    // Gets user value for checking if value exists in List
    static bool checkExists()
    {
      string userInput;
      Console.WriteLine("What value would like to check for? (Note: Case Sensitive)");
      userInput = Console.ReadLine();
      return includes(userInput);
    }

    // Displays all the items in the List
    public static string toString()
    {
      Node current = myLinkedList.Head;
      char openBrace = '{';
      char closeBrace = '}';
      string returnString = "";
      Console.Clear();

      while(current != null)
      {
        if(current.Next == null)
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
  }
}
