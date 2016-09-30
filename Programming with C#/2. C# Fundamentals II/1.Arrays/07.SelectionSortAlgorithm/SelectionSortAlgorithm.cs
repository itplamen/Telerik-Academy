//07.Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
//Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, 
//move it at the second position, etc.

using System;

    class SelectionSortAlgorithm
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of the array: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];

            Console.WriteLine("Enter elements of the array...");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Index {0} -> ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int number = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        number = array[j];
                        array[j] = array[i];
                        array[i] = number;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
        }
    }

