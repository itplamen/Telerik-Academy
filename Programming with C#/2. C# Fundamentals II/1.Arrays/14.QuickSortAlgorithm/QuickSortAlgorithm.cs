//14.Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;

    class QuickSortAlgorithm
    {
        static void Quicksort(string [] elements, int left, int right)
        {
            int i = left;
            int j = right;
            string middle = elements[(left + right) / 2];
            while (i <= j)
            {
                while (elements[i].CompareTo(middle) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(middle) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    string tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }

        static void PrintArray(string[] elements)
        {
            foreach (string element in elements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("How many string elements you want to enter: ");
            int numberOfElements = int.Parse(Console.ReadLine());

            string[] elements = new string[numberOfElements];

            Console.WriteLine("Enter elements: ");
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write("Enter string: ");
                elements[i] = Console.ReadLine();
            }

            int left  = 0;
            int right = elements.Length - 1;

            Console.Write("The unsorted array looks like: ");
            PrintArray(elements);
            Quicksort(elements, left, right);
            Console.Write("The sorted array looks like: ");
            PrintArray(elements);
        }
    }

