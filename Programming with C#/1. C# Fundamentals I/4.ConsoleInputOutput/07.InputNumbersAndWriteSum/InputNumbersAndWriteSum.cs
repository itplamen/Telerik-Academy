//7.Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class InputNumbersAndWriteSum
{
    static void Main(string[] args)
    {
        Console.Write("How many numbers you want to enter: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            double number = double.Parse(Console.ReadLine());

            sum += number;
        }

        Console.WriteLine("Sum of the numbers is: " + sum);
    }
}

