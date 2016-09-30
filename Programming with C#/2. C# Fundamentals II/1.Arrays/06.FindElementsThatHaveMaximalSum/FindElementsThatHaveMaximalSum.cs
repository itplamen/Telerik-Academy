//06.Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

using System;

    class FindElementsThatHaveMaximalSum
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Enter elements of the array...");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());

            if (k <= n)
            {
                int currentSum = 0;
                int maximalSum = 0;
                string currentNumbers = "";
                string numbers = "";

                for (int i = 0; i < array.Length; i++)
                {
                    if (i+k > array.Length)
                    {
                        break;
                    }
                    for (int j = i; j < i + k; j++)
                    {
                        currentSum += array[j];
                        currentNumbers = currentNumbers + " " + array[j];
                    }
                    if (currentSum > maximalSum)
                    {
                        maximalSum = currentSum;
                        numbers = currentNumbers;
                    }
                    currentSum = 0;
                    currentNumbers = " ";
                }
                Console.WriteLine("The numbers are: " + numbers);
                Console.WriteLine("The maximal sum is: " + maximalSum);
            }
            else
            {
                Console.WriteLine("ERROR!!! \"K\"  must be smaller than \"N\". Try again...");
                Main();
            }
        }
    }

