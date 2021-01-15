# Challenge Summary
Write a function called BinarySearch which takes in 2 parameters: a sorted array and the search key. Without utilizing any of the built-in methods available to your language, return the index of the array’s element that is equal to the search key, or -1 if the element does not exist.

## Challenge Description
Write a search function that takes in a sorted array and a search value.  Then search for the value by splitting the array in half with each repetition.

## Approach & Efficiency
Approach we took was tracking the endpoints of the array and adjusting the endpoints with every repetition so we can narrow our search by halving our search area with each repetition.  The function then returned the index of the found value or -1.

## Solution
[Code Challenge 3 - Whiteboard](./assets/binary_search.png)
