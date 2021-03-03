# Code Challenge: Class 36: Graph Implementation

## Author: Alan Hung

### Challenge Summary
* Create a Vertex class which when instantiated is an object that contains a value.
* Create an Edge class which when instantiated contains references to Vertex Location and a variable int value.
* Create a Graph class that creates a List of Vertices that are interconnected to other Nodes via edge.
* Within your Graph class, include an Adjaceny List that stores all the Vertices and the list of their edges.
  * Define a method called Add which adds a vertex to the graph adjacency List
  * Define a method called AddDirectedEdge which connects a vertex to another vertex in the graph
  * Define a method called AddUnDirectedEdge which connects 2 vertices to each other.
  * Define a method called GetNeighbors that returns all the vertices connected to specified vertex.
  * Define a method called Size that returns the size of the graph
  * Define a method called GetNodes that returns a list of all the vertices in a graph.

### Challenge Summary Part 2
* Write a method called BreadthFirst Search which will return the vertices in a graph in Level Search Order.

### Challenge Description
* Create a Graph with a working AddNode, AddDirectedEdge, AddUndirectedEdge, GetNeighbors, Size and GetNodes methods
* Create BreadthFirstSearch method that returns the list of vertices in Breadth First Search Order

### Approach & Efficiency
* Create a Hash Map Class with an array that stores linked list key value pair strings.
* __Hash__ takes in a string and converts it into an int value.
  * Efficiency: O(n)
* __Add__ takes in a key and a value and hashes an address location from the key, then adds the key value pair into the table at address location.  If location is not empty, adds data to beginning of list.
  * Efficiency: O(1)
* __Get__ takes in a key and hashes an address location.  Then if location is not empty, will traverse the location to find the key value pair and return the value.
  * Efficiency: O(n)
* __Contains__ takes in a key and hashes an address location.  Then if location is not empty, will traverse the location to find the key value pair and return a boolean indicating if the value was found.
  * Efficiency: O(log n)
* __FirstRepeatedWord__ Takes in a long string, parses the string, then hashes the words to a Hash Map.  It then returns the first duplicate word it finds or it returns null.
  * Efficiency: O(n)
* __TreeIntersection__ Takes in 2 separate trees, then traverses both trees and returns a list of all intersecting values.  Returns null or empty list for edge cases.
  * Efficiency: O(n)
* __LeftJoin__ Takes in 2 separate hash maps, then combines the data in both maps and returns a list of all resulting combined data.  Returns empty list for edge cases.
  * Efficiency: O(Nlogn)

### Solution
* [First Repeated Word - Whiteboard](./HashTable/HashTable/assets/repeated-word.png)
* [Intersecting Trees - Whiteboard](./HashTable/HashTable/assets/TreeIntersection.PNG)
* [Left Join - Whiteboard](./HashTable/HashTable/assets/left-sort.png)

### Example
![Append - Whiteboard](./HashTable/HashTable/assets/ExampleProgram.PNG)

### Change Log
* 0.2.0 - 2/22/2021 11:33pm - Created HashMap Class with Hash Method
* 0.4.0 - 2/22/2021 11:33pm - Created Add Method
* 0.6.0 - 2/22/2021 11:33pm - Created Get Method
* 0.8.0 - 2/22/2021 11:33pm - Created Contains Method
* 1.0.0 - 2/22/2021 11:33pm - Created Program to test all Methods
* 1.1.0 - 2/22/2021 11:33pm - Created FirstRepeatedWord Method
* 1.2.0 - 2/22/2021 11:14pm - Created TreeIntersection Method
* 1.3.0 - 2/22/2021 12:04am - Created LeftJoin Method

### Attribution
* [Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/)
