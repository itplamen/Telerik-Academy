//20. Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
//Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

    class GenerateVariationsOfElements
    {
        static void Variations(int[] array, int n, int index)
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
                for (int i = 1; i <= n; i++)
                {
                    array[index] = i;
                    Variations(array, n, index + 1);
                }
            }
        }

        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[k];

            Variations(array, n, 0);
        }
    }

