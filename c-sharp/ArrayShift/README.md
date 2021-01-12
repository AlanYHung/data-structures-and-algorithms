# Challenge Summary
Write a function called insertShiftArray which takes in an array and the value to be added. Without utilizing any of the built-in methods available to your language, return an   array with the new value added at the middle index.

## Challenge Description
Create a function called insertShiftArray that takes in 2 parameters (int array, int value).  The function will return a new array with the parameter value inserted into the center of the array.

## Approach & Efficiency
Created a new Array that had a max length of 1 + the max length of the passed in array.  Calculated the midpoint of the new array by taking the length of the new array and dividing by 2.  Assumption that truncating will be handled automatically due to variable type handling.  Then traversed the 2 arrays simultaneously and copied over values before and after midpoint.

## Solution
[Code Challenge 2 - Whiteboard](./assets/array-shift.pdf)
