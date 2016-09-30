//09.Write a method that return the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Linq;

    class MaximalEementInPortionOfArray
    {
        static void SortArray(int[] array)
        {
            int number = 0;
            //Sorting an array in ascending order
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        number = array[j];
                        array[j] = array[i];
                        array[i] = number;
                    }
                }
            }
            
            //Print array in ascending order
            Console.WriteLine("Sort array...");
            Console.Write("In  ascending order: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();

            //Sorting array in descending order
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        number = array[j];
                        array[j] = array[i];
                        array[i] = number;
                    }
                }
            }

            //Print array int descendin 
            Console.Write("In descending order: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }

        static void MaximalElementInArray(int[] array)
        {
            int maximalElement = array.Max();
            Console.WriteLine("The maximal element in array is: " + maximalElement);
        }

        static void MaximalElementInPortiontOfArray(int[] array, int firstIndex)
        {
            int maximalElementInPortion = 0;
            for (int i = firstIndex; i < array.Length; i++)
            {
                if (array[i] > maximalElementInPortion)
                {
                    maximalElementInPortion = array[i]; 
                }
            }
            Console.WriteLine("Max element in the portion of array is: " + maximalElementInPortion);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];

            Console.WriteLine("Enter array elements...");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Index [{0}] -> ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter first index of the portion where you want to search: ");
            int firstIndex = int.Parse(Console.ReadLine());

            MaximalElementInArray(array);
            MaximalElementInPortiontOfArray(array, firstIndex);
            SortArray(array); 
        }
    }