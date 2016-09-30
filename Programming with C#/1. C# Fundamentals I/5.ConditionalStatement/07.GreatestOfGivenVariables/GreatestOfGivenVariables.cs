//7.Write a program that finds the greatest of given 5 variables.

using System;

class GreatestOfGivenVariables
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the fourth number: ");
        double fourthNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter the fifth number: ");
        double fifthNumber = double.Parse(Console.ReadLine());

        double greatestNumber = firstNumber;
        if (greatestNumber < secondNumber)
        {
            greatestNumber = secondNumber;
        }
        if (greatestNumber < thirdNumber)
        {
            greatestNumber = thirdNumber;
        }
        if (greatestNumber < fourthNumber)
        {
            greatestNumber = fourthNumber;
        }
        if (greatestNumber < fifthNumber)
        {
            greatestNumber = fifthNumber;
        }

        Console.WriteLine("\nThe greatest number is: " + greatestNumber);
    }
}

