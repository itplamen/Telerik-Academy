//11.Write a program that finds the index of given element in a sorted array of integers by using the binary search 
//algorithm (find it in Wikipedia).

using System;

class BinarySearchAlgorithm
{
    static void Main(string[] args)
    {
        Console.Write("Enter array length: ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] array = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Index {0} -> ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Array.Sort(array);
        int left = 0;
        int right = array.Length - 1;
        int middle = 0;
        int index = 0;

        for (int i = 0; i < array.Length-1; i++)
        {
            middle = (left + right) / 2;

            if (number == array[middle])
            {
                index = middle;
                Console.WriteLine("The number index is: {0}", index);
                break;
            }
            if (number < array[middle])
            {
                right = middle - 1;
            }
            if (number > array[middle])
            {
                left = middle + 1;
            }
        }
        if (index != middle)
        {
            Console.WriteLine("There is no such number in the array!!!");
        }
    }
}