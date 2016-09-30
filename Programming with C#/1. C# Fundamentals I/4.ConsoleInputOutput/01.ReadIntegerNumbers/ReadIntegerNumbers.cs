//1.Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class ReadIntegerNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Sum of the number is: {0}", firstNumber + secondNumber + thirdNumber);
    }
}

