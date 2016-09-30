//7.Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

using System;

class FibonacciSum
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        uint n = uint.Parse(Console.ReadLine());

        decimal firstNumber = 0;
        decimal secondNumber = 1;
        decimal sum = 0;

        Console.WriteLine("The number's are: ");
        for (int i = 1; i <= n; i++)
        {
            decimal temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = secondNumber + temp;
            sum += firstNumber;

            Console.WriteLine(firstNumber);
        }

        Console.WriteLine("The sum is: " + sum);
    }
}

