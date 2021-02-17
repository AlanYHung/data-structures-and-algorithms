using System;

namespace MergeSort
{
  class Program
  {
    static void Main(string[] args)
    {
      MergeSort(new int[] { 8, 4, 23, 42, 16, 15 });
    }

    static void DisplayArray(int[] array)
    {
      Console.Write("[");

      foreach (var item in array)
      {
        Console.Write(" {0} ", item);
      }

      Console.WriteLine("]");
    }

    static int[] ArrayCopy(int[] array, int newLength, int startingIndex)
    {
      int[] newArray = new int[newLength];

      for(int i = 0; i < newLength; i++)
      {
        newArray[i] = array[startingIndex++];
      }

      return newArray;
    }

    static void MergeSort(int[] array)
    {
      Console.WriteLine();
      Console.Write("Original Array: ");
      DisplayArray(array);
      int n = array.Length;

      if (n > 1)
      {
        int mid = n / 2;
        int[] left = ArrayCopy(array, mid, 0);
        Console.Write("Left Array: ");
        DisplayArray(left);
        int[] right = ArrayCopy(array, n - mid, mid);
        Console.Write("Right Array: ");
        DisplayArray(right);

        MergeSort(left);
        MergeSort(right);
        Merge(left, right, array);
      }
    }

    static void Merge(int[] left, int[] right, int[] arr)
    {
      Console.WriteLine();
      Console.WriteLine("==================================");
      Console.WriteLine("========= Merge Original =========");
      Console.WriteLine("==================================");
      Console.WriteLine();
      Console.Write("Original Array: ");
      DisplayArray(arr);
      Console.Write("Left Array: ");
      DisplayArray(left);
      Console.Write("Right Array: ");
      DisplayArray(right);
      Console.WriteLine();


      int i = 0;
      int j = 0;
      int k = 0;

      while(i < left.Length && j < right.Length)
      {
        if(left[i] <= right[j])
        {
          arr[k] = left[i];
          i++;
        }
        else
        {
          arr[k] = right[j];
          j++;
        }

        k++;
      }

      if (i == left.Length)
      {
        for(i = j; i < right.Length; i++)
        {
          arr[k] = right[j];
          k++;
          j++;
        }
      }
      else
      {
        for (j = i; j < left.Length; j++)
        {
          arr[k] = left[i];
          k++;
          i++;
        }
      }

      Console.WriteLine();
      Console.WriteLine("==================================");
      Console.WriteLine("========= Merge Updated ==========");
      Console.WriteLine("==================================");
      Console.WriteLine();
      Console.Write("Original Array: ");
      DisplayArray(arr);
      Console.Write("Left Array: ");
      DisplayArray(left);
      Console.Write("Right Array: ");
      DisplayArray(right);
      Console.WriteLine();
    }
  } // end of class
} // end of namespace
