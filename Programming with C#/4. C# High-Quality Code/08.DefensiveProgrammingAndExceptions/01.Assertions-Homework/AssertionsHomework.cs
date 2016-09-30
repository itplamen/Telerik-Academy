//01.Add assertions in the code from the project "Assertions-Homework" to ensure all possible preconditions and 
//postconditions are checked.

namespace _01.Assertions_Homework
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
   
    public class AssertionsHomework
    {
        public static void SelectionSort<T>(T[] array) where T : IComparable<T>
        {
            Debug.Assert(array != null, "Array is null!");

            for (int index = 0; index < array.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(array, index, array.Length - 1);
                Swap(ref array[index], ref array[minElementIndex]);
            }
        }

        private static int FindMinElementIndex<T>(T[] array, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(startIndex >= 0, "Value of startIndex {" + startIndex + "} is negative!");
            Debug.Assert(endIndex > 0, "Value of endIndex {" + endIndex + "} is negative!"); 
            Debug.Assert(startIndex < endIndex, "Value of startIndex is bigger than value of endIndex!");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (array[i].CompareTo(array[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            bool isMinElement = IsMinElement(array, minElementIndex, startIndex);
            Debug.Assert(isMinElement == true, "Value {" + array[minElementIndex] + "} is not minimal element in the array!");

            return minElementIndex;
        }

        private static bool IsMinElement<T>(T[] array, int minElementIndex, int startIndex)
            where T : IComparable<T>
        {
            for (int i = startIndex; i < array.Length; i++)
            {
                if (array[minElementIndex].CompareTo(array[i]) == 1)
                {
                    return false;
                }
            }

            return true;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }

        public static int BinarySearch<T>(T[] array, T value) 
            where T : IComparable<T>
        {
            bool isArraySorted = IsArraySorted(array);
            Debug.Assert(isArraySorted == true, "Array is not sorted!");

            return BinarySearch(array, value, 0, array.Length - 1);
        }

        private static bool IsArraySorted<T>(T[] array)
            where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(startIndex >= 0, "Value of startIndex {" + startIndex + "} is negative!");
            Debug.Assert(endIndex > 0, "Value of endIndex {" + endIndex + "} is negative!");
            Debug.Assert(startIndex < endIndex, "Value of startIndex is bigger than value of endIndex!");

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

        public static void Main(string[] args)
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
}
