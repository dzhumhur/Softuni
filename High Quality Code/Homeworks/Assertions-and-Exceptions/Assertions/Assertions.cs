using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics;

class Assertions
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            Debug.Assert(arr[i].CompareTo(arr[i + 1]) < 0, "Selection Sort is not correct");
        }
    }
  
    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            var currNumber = arr[minElementIndex];
            var nextNumber = arr[i];
            var compareCurrAndNextNumber = nextNumber.CompareTo(currNumber);
            if (compareCurrAndNextNumber < 0)
            {
                minElementIndex = i;
            }
        }
        return minElementIndex;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Debug.Assert(arr[i].CompareTo(arr[i + 1]) < 0, "Array should be sorted");
        }

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else 
            {
                // Search on the left half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}
