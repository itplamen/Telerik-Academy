//1.Write an if statement that examines two integer variables and exchanges their values if the first one is greater than 
//the second one.

using System;

class ExchangeValues
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            int current = firstNumber;
            firstNumber = secondNumber;
            secondNumber = current;

            Console.WriteLine("After exchange...\n");
            Console.WriteLine("First number is: {0}, second number is: {1}", firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("ERROR. First number must be greater than the second one. Try again...");
            Console.WriteLine();
            Main();
        }
    }
}

