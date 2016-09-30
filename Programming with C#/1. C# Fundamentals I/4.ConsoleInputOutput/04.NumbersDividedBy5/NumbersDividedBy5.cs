//4.Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the 
//reminder of the division by 5 is 0 (inclusive). 
//Example: p(17,25) = 2.

using System;

class NumbersDividedBy5
{
    static void Main()
    {
        Console.Write("Enter first numebr: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int result = 0;

        if (firstNumber > secondNumber)
        {
            Console.WriteLine("ERROR. First number must be bigger than second number. Try again...");
            Console.WriteLine();
            Main();
        }
        else
        {
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    result++;
                }
            }

            Console.WriteLine("p({0}, {1}) = {2}", firstNumber, secondNumber, result);
        }
    }
}

