//9.Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class SequenceOfFibonacci
{
    static void Main(string[] args)
    {
        decimal firstNumber = 0;
        decimal secondNumber = 1;

        for (int i = 1; i <= 100; i++)
        {
            decimal temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = secondNumber + temp;
            Console.WriteLine("{0}: {1}", i, firstNumber);
        }
    }
}

