//1.Write a program that prints all the numbers from 1 to N.

using System;

class PrintNumbersFrom1toN
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

