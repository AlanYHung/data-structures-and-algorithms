using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class AnimalShelter
  {
    public Queue<CatDog> Shelter { get; set; }

    public AnimalShelter()
    {
      Queue<CatDog> newQueue = new Queue<CatDog>();
      Shelter = newQueue;
    }

    public void enqueue(CatDog animal)
    {
      Shelter.Enqueue(animal);
    }

    public CatDog dequeue(CatDog pref)
    {
      Queue<CatDog> tempQ = new Queue<CatDog>();
      Node<CatDog> removedNode = new Node<CatDog>();
      Node<CatDog> savedNode = new Node<CatDog>();
      bool found = false;

      if (Shelter.IsEmpty())
      {
        throw new NullReferenceException();
      }
      else
      {
        while (!Shelter.IsEmpty())
        {
          removedNode = Shelter.Dequeue();

          // Saves the first pref found and makes sure it will only be found once
          if(removedNode.Value.Equals(pref) && !found)
          {
            savedNode = removedNode;
            found = true;
          }
          // Adds the removed Nodes into a new Queue to ensure no loss of data
          else
          {
            tempQ.Enqueue(removedNode.Value);
          }
        }// end while

        // Makes Shelter equal to the new list
        Shelter = tempQ;
        return savedNode.Value;
      }
    }// end dequeue
  }

  // Created an Enum to force Types and remove edge cases
  public enum CatDog
  {
    Dog,
    Cat
  }
}
