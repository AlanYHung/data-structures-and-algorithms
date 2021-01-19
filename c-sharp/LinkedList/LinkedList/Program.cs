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
            methodOfAdd();
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
            Console.WriteLine(myLinkedList.toString());
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
            myLinkedList.insert("!!!");
            break;
          case 1:
            myLinkedList.insert("World");
            break;
          case 2:
            myLinkedList.insert("Hello");
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

    // Gets user input value for insert function
    static void addToList()
    {
      string userInput;

      do
      {
        Console.Write("Add a value to the linked list: ");
        userInput = Console.ReadLine();
        myLinkedList.insert(userInput);

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

    // Shows user current list and gets the location of item to insert before or after and new item to insert
    static void insertBeforeOrAfter(string userChoice)
    {
      string listValue;
      string newValue;

      Console.WriteLine(myLinkedList.toString());
      Console.Write("\nPlease choose a value to insert your item {0}: ", userChoice);
      listValue = Console.ReadLine();
      Console.Write("Please choose a value to insert: ");
      newValue = Console.ReadLine();

      switch (userChoice)
      {
        case "before":
          try
          {
            myLinkedList.insertBefore(listValue, newValue);
          }
          catch(Exception e)
          {
            Console.WriteLine("\n\n{0}",e);
            pauseScreen();
          }
          break;
        case "after":
          try
          {
            myLinkedList.insertAfter(listValue, newValue);
          }
          catch (Exception e)
          {
            Console.WriteLine("\n\n{0}", e);
            pauseScreen();
          }
          break;
        default:
          break;
      }
    }

    // Allows user to choose add method
    static void methodOfAdd()
    {
      string userInput;

      Console.WriteLine("Please choose how you would like to add to the list: ");
      Console.WriteLine("\n\n1. Insert new item to beginning of the list");
      Console.WriteLine("2. Append to the end of the list");
      Console.WriteLine("3. Insert new list time before existing list item");
      Console.WriteLine("4. Insert new list time after existing list item");
      Console.WriteLine("5. Exit");
      Console.Write("\n\nPlease choose a number between 1-5: ");
      userInput = Console.ReadLine();
      Console.Clear();

      switch (userInput)
      {
        case "1":
          addToList();
          break;
        case "2":
          Console.WriteLine("What item would you like to add to the end of the list?");
          userInput = Console.ReadLine();
          myLinkedList.append(userInput);
          break;
        case "3":
          insertBeforeOrAfter("before");
          break;
        case "4":
          insertBeforeOrAfter("after"); 
          break;
        case "5":
          break;
        default:
          Console.WriteLine("Invalid Choice.  Need to choose a number between 1 and 5.");
          pauseScreen();
          break;
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
            myLinkedList.delete(userInputConverted - 1);
          }
        }
        catch (Exception e)
        {
          Console.Clear();
          Console.WriteLine("Please enter a number.\n\n{0}", e);
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

    // Gets user value for checking if value exists in List
    static bool checkExists()
    {
      string userInput;
      Console.WriteLine("What value would like to check for? (Note: Case Sensitive)");
      userInput = Console.ReadLine();
      return myLinkedList.includes(userInput);
    }
  }
}
