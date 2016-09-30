//8.Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], 
//each on a single line.

using System;

class PrintNumbersInTheInterval
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Numbers in the interval [1 .. {0}] are: ", n);

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

