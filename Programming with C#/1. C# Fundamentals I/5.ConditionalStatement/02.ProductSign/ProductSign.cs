//2.Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
//Use a sequence of if statements.

using System;

class ProductSign
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("The product of the number's is POSITIVE");
        }
        else if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The produc of the number's is 0");
        }
        else if (firstNumber < 0 ^ secondNumber < 0 ^ thirdNumber < 0)
        {
            Console.WriteLine("The product of the number's is NEGATIVE");
        }
        else if ((firstNumber < 0 && secondNumber < 0 && thirdNumber > 0) || (firstNumber < 0 && thirdNumber < 0 && secondNumber > 0) || (secondNumber < 0 && thirdNumber < 0 && firstNumber > 0))
        {
            Console.WriteLine("The product of the number's is POSITIVE");
        }
    }
}

