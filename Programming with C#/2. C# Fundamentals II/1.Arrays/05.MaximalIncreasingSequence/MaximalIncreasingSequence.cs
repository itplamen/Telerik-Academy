//05.Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

using System;

    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of the arrayaaaaa: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];

            Console.WriteLine("Enter elements of the array...");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Enter number: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int currentLen = 1;
            int bestLen = 0;
            int elements = 0;
            int start = 0;

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] < array[i+1])
                {
                    currentLen++;
                    if (currentLen > bestLen)
                    {
                        bestLen = currentLen;
                        elements = start;
                    }
                }
                else
                {
                    currentLen = 1;
                    start = i + 1;
                }
            }

            for (int i = elements; i < bestLen + elements; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

