//01. Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;

    class ConvertDecimalToBinaryNumeralSystem
    {
        static void ConvertToBinary(int number)
        {
            List<int> result = new List<int>();
            while (number > 0)
            {
                result.Add(number % 2);
                number /= 2;
            }

            result.Reverse();
            foreach (int element in result)
            {
                Console.Write(element);
            }
            Console.WriteLine();
        }
       
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            ConvertToBinary(number);
        }
    }

