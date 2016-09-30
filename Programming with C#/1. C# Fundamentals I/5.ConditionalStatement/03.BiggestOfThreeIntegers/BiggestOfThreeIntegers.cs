//3.Write a program that finds the biggest of three integers using nested if statements.

using System;

class BiggestOfThreeIntegers
{
    static void Main(string[] args)
    {
        Console.Write("Enter first integer number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter third integer number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber == secondNumber && firstNumber == thirdNumber)
        {
            Console.WriteLine("The numbers are equal!");
        }
        else
        {
            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("The biggest number is: " + firstNumber);
                } 
            }
            else
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine("The biggest number is: " + secondNumber);
                }
                else
                {
                    Console.WriteLine("The biggest number is: " + thirdNumber);
                }
            }
        }
    }
}

