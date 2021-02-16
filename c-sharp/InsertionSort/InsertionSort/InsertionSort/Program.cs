using System;

namespace InsertionSort
{
  public class Program
  {
    static void Main(string[] args)
    {
      int[] reverseSort = new int[] { 20, 18, 12, 8, 5, -2 };
      int[] fewUniques = new int[] { 5, 12, 7, 5, 5, 7 };
      int[] nearlySorted = new int[] { 2, 3, 5, 7, 13, 11 };

      Console.WriteLine();
      Console.WriteLine("=======================================");
      Console.WriteLine("======== Reverse Sorted Array =========");
      Console.WriteLine("=======================================");
      Console.WriteLine();
      reverseSort = InsertionSort(reverseSort);
      DisplayArray(reverseSort);
      Console.WriteLine();
      Console.WriteLine("=======================================");
      Console.WriteLine("========== Few Uniques Array ==========");
      Console.WriteLine("=======================================");
      Console.WriteLine();
      fewUniques = InsertionSort(fewUniques);
      Console.WriteLine();
      Console.WriteLine("=======================================");
      Console.WriteLine("========= Nearly Sorted Array =========");
      Console.WriteLine("=======================================");
      Console.WriteLine();
      nearlySorted = InsertionSort(nearlySorted);
    }

    public static int[] InsertionSort(int[] sortArr)
    {
      DisplayArray(sortArr);

      for(int i = 1; i < sortArr.Length; i++)
      {
        int j = i - 1;
        int temp = sortArr[i];

        while(j >= 0 && temp < sortArr[j])
        {
          sortArr[j + 1] = sortArr[j];
          j -= 1;
        }

        sortArr[j + 1] = temp;
        DisplayArray(sortArr);
      }

      return sortArr;
    }

    static void DisplayArray(int[] sortedArray)
    {
      Console.Write("[");

      foreach (int item in sortedArray)
      {
        Console.Write(" {0} ", item);
      }

      Console.WriteLine("]");
    }
  } // end of class
} // end of namespace
