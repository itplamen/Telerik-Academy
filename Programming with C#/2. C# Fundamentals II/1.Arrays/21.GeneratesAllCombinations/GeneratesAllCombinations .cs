//21. Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from 
//the set [1..N]. 
//Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;

    class GeneratesAllCombinations 
    {
        static void Combinations(int[] array, int n, int index, int tempNumber)
        {
            if (index == array.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }

            else
            {
                for (int i = tempNumber; i <= n; i++)
                {
                    array[index] = i;
                    Combinations(array, n, index + 1, i+1);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[k];

            Combinations(array, n, 0, 1);
        }
    }

