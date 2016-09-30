//4.Sort 3 real values in descending order using nested if statements.

using System;

class SortValuesInDescendingOrder
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

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
                    if (secondNumber > thirdNumber)
                    {
                        Console.WriteLine("{0} \n{1} \n{2}", firstNumber, secondNumber, thirdNumber);
                    }
                    else
                    {
                        Console.WriteLine("{0} \n{1} \n{2}", firstNumber, thirdNumber, secondNumber);
                    }
                }
                else
                {
                    Console.WriteLine("{0} \n{1} \n{2}", thirdNumber, firstNumber, secondNumber);
                }
            }
            else if (secondNumber > thirdNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("{0} \n{1} \n{2}", secondNumber, firstNumber, thirdNumber);

                }
                else
                {
                    Console.WriteLine("{0} \n{1} \n{2}", secondNumber, thirdNumber, firstNumber);
                }
            }
            else
            {
                Console.WriteLine("{0} \n{1} \n{2}", thirdNumber, secondNumber, firstNumber);
            }
        }
    }
}

