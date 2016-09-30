//10.Write a program that finds in given array of integers a sequence of given sum S (if present). 
//Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	

using System;

    class SequenceOfGivenSumInGivenArray
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

            Console.Write("Enter S: ");
            int s = int.Parse(Console.ReadLine());

            int currentSum = array[0];
            int firstIndex = 0;
            int lastIndex = 0;
            int startIndex = 0;

            for (int i = 0; i < array.Length-1; i++)
            {
                if (currentSum < s)
                {
                    currentSum += array[i + 1];
                    firstIndex = i;
                }
                if (currentSum > s)
                {
                    currentSum -= array[startIndex];
                    startIndex++;
                }
                if (currentSum == s)
                {
                    startIndex--;
                    lastIndex = i;
                    firstIndex = lastIndex - startIndex;  
                }
            }

            for (int i = firstIndex; i <= lastIndex; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

