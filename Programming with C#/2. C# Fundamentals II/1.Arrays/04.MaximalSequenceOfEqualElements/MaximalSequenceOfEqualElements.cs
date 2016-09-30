//04.Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;

    class MaximalSequenceOfEqualElements
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

            int currentLen = 1;
            int bestLen = 0;
            int elements = 0;

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == array[i+1])
                {
                    currentLen++;
                    if (currentLen > bestLen)
                    {
                        bestLen = currentLen;
                        elements = array[i];
                    }
                }
                else
                {
                    currentLen = 1;
                }
            }

            for (int i = 0; i < bestLen; i++)
            {
                Console.Write(elements);
            }
            Console.WriteLine();
        }
    }

