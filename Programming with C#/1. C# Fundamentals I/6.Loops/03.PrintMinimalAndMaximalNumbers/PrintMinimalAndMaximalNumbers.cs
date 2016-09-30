//3.Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;
using System.Linq;

class PrintMinimalAndMaximalNumbers
{
    static void Main(string[] args)
    {
        Console.Write("How many number's you want to enter: ");
        int numbersCount = int.Parse(Console.ReadLine());

        int[] numbers = new int[numbersCount];

        for (int i = 0; i < numbersCount; i++)
        {
            Console.Write("Enter number : ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int minNumber = numbers.Min();
        int maxNumber = numbers.Max();

        Console.WriteLine("\nThe minimal number is: " + minNumber);
        Console.WriteLine("The maximal number is: " + maxNumber);
    }
}

