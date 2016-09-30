//09.Write a program that finds the most frequent number in an array. Example:
//    {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

using System;

    class MostFrequentNumberInAnArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of the array: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];

            Console.WriteLine("Enter elemnts of the array...");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Index {0} -> ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            int currentLen = 1;
            int maximalLen = 0;
            int number = 0;
            int repeats = 1;

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == array[i+1])
                {
                    currentLen++;
                    if (currentLen > maximalLen)
                    {
                        maximalLen = currentLen;
                        number = array[i];
                        repeats++;
                    } 
                }
                else
                {
                    currentLen = 1;
                }
            }
            Console.WriteLine("{0} -> {1} times", number, repeats);
        }
    }

