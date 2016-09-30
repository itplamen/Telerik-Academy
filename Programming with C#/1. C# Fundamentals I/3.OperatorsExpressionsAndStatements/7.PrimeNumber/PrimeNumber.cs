//7.Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter some positive integer number: ");
        uint number = uint.Parse(Console.ReadLine());

        if (number > 100)
        {
            Console.WriteLine("ERROR. The number must be <= 100. Try again...");
            Console.WriteLine();
            Main();
        }
        else if (((number % 2 != 0) && (number % 3 != 0) && (number % 5 != 0) && (number % 7 != 0)) ^
           ((number == 2) || (number == 3) || (number == 5) || (number == 7)))
        {
            Console.WriteLine("The entered number is PRIME!");
        }
        else
        {
            Console.WriteLine("The entered number is NOT PRIME");
        }
    }
}

