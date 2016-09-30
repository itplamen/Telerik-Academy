//08.Write a program that finds the sequence of maximal sum in given array. Example:
//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;

    class SequenceOFMaximalSumInGivenArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of the array: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];

            Console.WriteLine("Enter elements of the array...");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Enter number: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            //Here im using the Kadane's algorithm
            int currentSum = array[0];
            int maxSum = array[0];
            int firstIndex = 0;
            int tempIndex = 0;
            int lastIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (currentSum > 0)
                {
                    currentSum += array[i];
                    firstIndex = i;
                }
                else
                {
                    currentSum = array[i];
                    tempIndex = i;
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    lastIndex = i;
                }
                firstIndex = tempIndex;
            }

            for (int i = firstIndex; i <= lastIndex; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

