using System;
using System.Linq;
using System.Diagnostics;

class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        var valueType = arr.GetType();
        var arrayLength = arr.Length;
        Debug.Assert(valueType.IsArray, "The input element is not an array!");
        Debug.Assert(arr.Length > 0, "The input array must contain at least 1 element!");

        for (int index = 0; index < arr.Length-1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        Debug.Assert(arrayLength == arr.Length,
            "SelectionSort method returns array with different length than the original array!");
    }
  
    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        var valueType = arr.GetType();
        Debug.Assert(valueType.IsArray, "FindMinElementIndex method does not get array as first argument!");
        Debug.Assert(startIndex >= 0 && startIndex < arr.Length,
            "FindMinElementIndex method gets wrong index as second argument!");
        Debug.Assert(endIndex >= 1 && endIndex < arr.Length,
            "FindMinElementIndex method gets wrong index as third argument!");

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        Debug.Assert(minElementIndex >= 0 && minElementIndex < arr.Length,
            "FindMinElementIndex method returns index out of range!");

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        var typeOfX = x.GetType();
        var typeOfY = y.GetType();
        Debug.Assert(typeOfX == typeOfY, "X and Y in Swap method are of different types!");

        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        var inputArgumentType = arr.GetType();
        Debug.Assert(inputArgumentType.IsArray, "BinarySearch<T> method does not get array as first argument!");
        

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        var valueType = arr.GetType();
        Debug.Assert(valueType.IsArray, "BinarySearch method does not get array as first argument!");
        Debug.Assert(startIndex >= 0 && startIndex < arr.Length,
            "BinarySearch method gets wrong index as third argument!");
        Debug.Assert(endIndex >= 1 && endIndex < arr.Length,
            "BinarySearch method gets wrong index as fourth argument!");

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
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
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
