# __Insertion Sort__
  Insertion Sort is a sorting algorithm that takes a List of items and sorts it by bringing lower value elements in the list back to the beginning of the list. The traversal algorithm keeps track of the 1 + nth element, so you can change values in the array without losing track of the element being moved.

## __Pseudocode__

```
  InsertionSort(int[] arr)
  
    FOR i = 1 to arr.length
    
      int j <-- i - 1
      int temp <-- arr[i]
      
      WHILE j >= 0 AND temp < arr[j]
        arr[j + 1] <-- arr[j]
        j <-- j - 1
        
      arr[j + 1] <-- temp
```

## __Trace__

![](./insertionSort/insertionSort/assets/Step1.PNG)
![](./insertionSort/insertionSort/assets/Step2.PNG)
![](./insertionSort/insertionSort/assets/Step3.PNG)
![](./insertionSort/insertionSort/assets/Step4.PNG)
![](./insertionSort/insertionSort/assets/Step5.PNG)
![](./insertionSort/insertionSort/assets/Step6.PNG)

## Efficiency
  * Time: O(n^2)
    * The basic operation of this algorithm is comparison. This will happen nth triangular number of times, making this n squared algorithm
  * Space: O(1)
    * No additional space is being created. This array is being sorted in place, making this space at constant O(1).
