# Code Challenge: Class 05-14: Linked List Implementation

## Author: Alan Hung

### Challenge Summary
* Create a Node class that has properties for the value stored in the Node, and a pointer to the next Node.
* Within your LinkedList class, include a head property. Upon instantiation, an empty Linked List should be created.
  * Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
  * Define a method called includes which takes any value as an argument and returns a boolean result depending on whether that value exists as a Node’s value somewhere within the list.
  * Define a method called toString (or __str__ in Python) which takes in no arguments and returns a string representing all the values in the Linked List, formatted as:
    * "{ a } -> { b } -> { c } -> NULL"

### Challenge Summary Part 2
* Create an Append method as part of the LinkedList Class that adds new items to the end of the list.
* Create an InsertBefore method that will search for a list item and insert a new Node before that list item
* Create an InsertAfter method that will search for a list item and insert a new Node after that list item
* Create a KthFromEnd method that will take an int k and return the node value that is k spaces away from the end
* Create a ZipList method that will take in 2 lists and merge them via alternating nodes from each list
* Create a Stack with the methods Push, Pop, peek, and IsEmpty
* Create a Queue with the methods Enqueue, Dequeue, peek, and IsEmpty
* Create a Class called PseudoQueue that mimics a Queue using 2 stacks
* Create a Class called AnimalShelter that has a Queue of Cats and Dogs and has an enqueue and dequeue method
* Create a method called MultiBracketValidation that takes in a string and returns a bool

### Challenge Description
* Create a functioning Linked List with insert, display, and search functionality.
* Append method adds new items to the end of the list
* InsertBefore method inserts a new Node with inputed value before a user chosen value
* InsertAfter method inserts a new Node with inputed value after a user chosen value
* KthFromEnd method will tell you the node that is k positions away from the end of the list
* ZipList will take 2 linked lists and merge them together via alternating nodes
* Create Stack where Push adds node, Pop removes node, peek returns value of top node, and IsEmpty lets you know if Stack is empty
* Create Queue where Enqueue adds node, Dequeue removes node, peek returns value of top node, and IsEmpty lets you know if Queue is empty
* Create a new PseudoQueue Class that has an enqueue and dequeue method, but uses stacks to mimic Queue FIFO principles
* Create a new AnimalShelter Class that has an enqueue and dequeue method and works with dog and cat types
* MultiBracketValidation method checks a string for ()[]{} and lets the user know that every open bracket is matched by a closing bracket in the correct order.

### Approach & Efficiency
* Create a Node Class with value and pointer.
* Create a Linked List class with head pointer and to instantiate an empty list.
* __insert__ create a new node and set pointer to the Head's next node, and reset Head to new Node.
  * Efficiency: O(1)
* __includes__ create a pointer to traverse the list until you find value or reach end of list
  * Efficiency: O(n)
* __toString__ create a pointer to traverse the list and pull out the value.  Then append to string. Return the string.
  * Efficiency: O(n)
* __Append__ traverses to end of list and adds the new node to the end
  * Efficiency: O(n)
* __InsertBefore__ traverses to the Node before chosen value and inserts Node in
  * Efficiency: O(n)
* __InsertAfter__ traverses to the Node and inserts the Node after
  * Efficiency: O(n)
* __KthFromEnd__ takes the length of the linked list then traverses to length - k node and returns value
  * Efficiency: O(n)
* __ZipList__ takes two lists and merges them into 1 list via alternating nodes
  * Efficiency: O(n)
* Stack Push is an insert function, Pop removes top node and resets top to next node, peek returns top nodes's value, and IsEmpty checks if top is null
  * Efficiency: O(n) / all methods
* Queue Enqueue is an insert function, Dequeue removes front node and resets front to next node, peek returns front nodes's value, and IsEmpty checks if front is null
  * Efficiency: O(n) / all methods
* PseudoQueue is a class that uses stacks to mimic Queue FIFO principles, it has an enqueue method that takes in a new value and adds it to the stack by reversing the stack then adding the new node first to the new stack, and a dequeue that removes the top node from the stack.
  * Efficiency: Enqueue: O(n) / Dequeue: O(1)
* AnimalShelter is a queue that follows FIFO principles with an enqueue method that does not have any different logic than normal, but dequeue will take in a pref of the user of dog or cat and remove the first instance of that type.
  * Efficiency: O(n) / all methods
* MultiBracketValidation will take in a string and traverse over the length of the string.  It pushes all open brackets onto a stack then checks all closing brackets against the stack.
  * Efficiency: O(n)

### Solution
* [Append - Whiteboard](./assets/append.png)
* [InsertBefore - Whiteboard](./assets/insert_before.png)
* [InsertAfter - Whiteboard](./assets/CodeChallenge06-insertafter.pdf)
* [KthFromEnd - Whiteboard](./assets/kthfromend.pdf)
* [ZipList - Whiteboard](./assets/ZipList.PNG)
* [QueueWithStacks - Whiteboard](./assets/QueueWithStacks.PNG)
* [AnimalShelter - Whiteboard](./assets/fifo-animal-shelter.png)
* [Multi-Bracket Validation - Whiteboard](./assets/MultiBracketCC13.PNG)

### Example
* ![](./assets/LinkedList1.PNG)
* ![](./assets/LinkedList2.PNG)
* ![](./assets/LinkedList3.PNG)
* ![](./assets/LinkedList4.PNG)

### Change Log
* 0.1.0 - 1/15/2021 2:00pm - Created Node Class and LinkedList Class
* 0.2.0 - 1/15/2021 2:30pm - Created user menu
* 0.3.0 - 1/15/2021 3:00pm - Created insert prompt and function
* 0.4.0 - 1/15/2021 3:30pm - Created includes function
* 0.5.0 - 1/15/2021 4:00pm - Created toString function
* 0.6.0 - 1/15/2021 4:30pm - Added Exception Handling
* 0.7.0 - 1/15/2021 5:00pm - Added delete menu
* 0.9.0 - 1/15/2021 6:00pm - Added delete function
* 1.0.0 - 1/15/2021 8:00pm - Finshed creating and running tests.
* 1.1.0 - 1/18/2021 6:30pm - Added append method
* 1.2.0 - 1/18/2021 7:00pm - Added insertBefore method
* 1.3.0 - 1/18/2021 7:30pm - Added insertAfter method
* 1.4.0 - 1/18/2021 8:00pm - Added new User menu for new add methods
* 1.5.0 - 1/18/2021 8:30pm - Unit Tests written and ran for new methods
* 1.6.0 - 1/19/2021 8:30pm - Implemented New Length Property and added tracking functionality to all Add methods
* 1.7.0 - 1/19/2021 9:00pm - Added User Interface Input and Output with Exception handling for new method
* 1.8.0 - 1/19/2021 9:30pm - Unit Tests written and ran for new method
* 1.9.0 - 1/22/2021 7:00pm - Stack Class implemented
* 2.0.0 - 1/22/2021 7:30pm - Queue Class implemented
* 2.2.0 - 1/25/2021 10:21pm - PseudoQueue Class implemented with enqueue and dequeue methods
* 2.4.0 - 1/26/2021 10:50pm - AnimalShelter Class implemented with enqueue and dequeue methods
* 2.5.0 - 1/27/2021 10:25pm - Created MutliBracketValidation & MutliBracketUserInput

### Attribution
* [Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/)
* [Stack Overflow](https://stackoverflow.com/questions/2695444/clearing-content-of-text-file-using-c-sharp)
