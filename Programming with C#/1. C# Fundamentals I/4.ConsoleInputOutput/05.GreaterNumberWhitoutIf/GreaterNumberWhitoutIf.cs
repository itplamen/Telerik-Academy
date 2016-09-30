//5.Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class GreaterNumberWhitoutIf
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("\nThe greater number is: " + Math.Max(firstNumber, secondNumber));
    }
}

