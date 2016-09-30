//02.Write a program that reads two arrays from the console and compares them element by element.

using System;

    class CompareTwoArrays
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of the two array's: ");
            int arraysLength = int.Parse(Console.ReadLine());

            int[] firstArray = new int[arraysLength];
            int[] secondArray = new int[arraysLength];

            Console.WriteLine("Enter element's of the first array...");
            for (int i = 0; i < arraysLength; i++)
            {
                Console.Write("Enter number: ");
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter element's of the second array... ");
            for (int i = 0; i < arraysLength; i++)
            {
                Console.Write("Enter number: ");
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            //Compare elements of the two arrays
            for (int i = 0; i < arraysLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    Console.WriteLine("{0} = {1}", firstArray[i], secondArray[i]);
                }
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("{0} < {1}", firstArray[i], secondArray[i]);
                }
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("{0} > {1}", firstArray[i], secondArray[i]);
                }
            }
            //Check if two arrays are EQUAL
            bool check = true;

            for (int i = 0; i < arraysLength; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    check = false;
                    break;
                }
            }
            if (check == true)
            {
                Console.WriteLine("The two arrays are EQUAL!");
            }
            else
            {
                Console.WriteLine("The two arrays are NOT EQUAL!");
            }
        }
    }

