# __Quick Sort__
Quick Sort is a sorting algorithm that takes an unsorted List and chooses a pivot point.
It then partitions(sorts) the list into 2 parts where the values smaller than the pivot value are moved before it (left partition),
and the values bigger than the pivot value are moved after it (right partition).  It continues this process for each partition until the partitions becomes a single
element list.  Then it merges all the sorted smaller lists into a single sorted list once again.

## __Pseudocode__

```
  ALGORITHM QuickSort(arr, left, right)
      if left < right
          // Partition the array by setting the position of the pivot value 
          DEFINE position <-- Partition(arr, left, right)
          // Sort the left
          QuickSort(arr, left, position - 1)
          // Sort the right
          QuickSort(arr, position + 1, right)

  ALGORITHM Partition(arr, left, right)
      // set a pivot value as a point of reference
      DEFINE pivot <-- arr[right]
      // create a variable to track the largest index of numbers lower than the defined pivot
      DEFINE low <-- left - 1
      for i <- left to right do
          if arr[i] <= pivot
              low++
              Swap(arr, i, low)

       // place the value of the pivot location in the middle.
       // all numbers smaller than the pivot are on the left, larger on the right. 
       Swap(arr, right, low + 1)
      // return the pivot index point
       return low + 1

  ALGORITHM Swap(arr, i, low)
      DEFINE temp;
      temp <-- arr[i]
      arr[i] <-- arr[low]
      arr[low] <-- temp
```

## __Trace__
![](../assets/quickSort.PNG)

## Efficiency
  * Time: O(Nlogn)
    * BigO time for quick sort is O(n*Log n) because it divide the array into halves and sorting happens as the halves are brought back together.
  * Space: O(n)
    * BigO space for merge sort is O(n) because no matter how many arrays you end up splitting the original array into you will still have the same amount of index values as the original array.
