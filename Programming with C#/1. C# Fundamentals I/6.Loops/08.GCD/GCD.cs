//8.Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
//Use the Euclidean algorithm (find it in Internet).

using System;

class GCD
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        while (firstNumber != 0 && secondNumber != 0)
        {
            if (firstNumber > secondNumber)
            {
                firstNumber %= secondNumber;
            }
            else
            {
                secondNumber %= firstNumber;
            }
        }

        if (firstNumber == 0)
        {
            Console.WriteLine(secondNumber);
        }
        else
        {
            Console.WriteLine(firstNumber);
        }
    }
}

