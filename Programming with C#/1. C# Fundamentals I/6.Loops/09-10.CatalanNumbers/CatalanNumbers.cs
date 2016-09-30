//9.In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
// (2*n)! / (n + 1)! * n!
//10.Write a program to calculate the Nth Catalan number by given N.
using System;

class CatalanNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        double n = double.Parse(Console.ReadLine());

        double factorialN = 1;
        double factoraialMultipleByTwo = 1;
        double factorialPlusOne = 1;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }

        for (int i = 1; i <= 2 * n; i++)
        {
            factoraialMultipleByTwo *= i;
        }

        for (int i = 1; i <= n + 1; i++)
        {
            factorialPlusOne *= i;
        }

        Console.WriteLine("(2*n)! / (n + 1)! * n!");
        Console.WriteLine("The result is: " + factoraialMultipleByTwo / (factorialPlusOne * factorialN));
    }
}

