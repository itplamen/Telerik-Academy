//03.Write a program that compares two char arrays lexicographically (letter by letter).

using System;

    class CompareTwoCharArraysLexicographically 
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of the two arrays: ");
            int arraysLength = int.Parse(Console.ReadLine());

            char[] firstArray = new char[arraysLength];
            char[] secondArray = new char[arraysLength];

            Console.WriteLine("Enter elements of the first array...");
            for (int i = 0; i < arraysLength; i++)
            {
                Console.Write("Enter letter: ");
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter elements of the second array...");
            for (int i = 0; i < arraysLength; i++)
            {
                Console.Write("Enter letter: ");
                secondArray[i] = char.Parse(Console.ReadLine());
            }

            int counterEven = 0;
            int counterFirst = 0;
            int counterSecond = 0;
            //Compare elements of the two arrays
            for (int i = 0; i < arraysLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    Console.WriteLine("{0} = {1}", firstArray[i], secondArray[i]);
                    counterEven++;
                }
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("{0} < {1}", firstArray[i], secondArray[i]);
                    counterFirst++;
                }
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("{0} > {1}", firstArray[i], secondArray[i]);
                    counterSecond++;
                }
            }

            if ((counterEven > counterFirst) && (counterEven > counterSecond))
            {
                Console.WriteLine("The two arrays are EQUAL");
            }
            if ((counterFirst > counterEven) && (counterFirst > counterSecond))
            {
                Console.WriteLine("The first array is earlier than second array");
            }
            if ((counterSecond > counterEven) && (counterSecond > counterFirst))
            {
                Console.WriteLine("The second array is earlier than fitst array");
            }
        }
    }

