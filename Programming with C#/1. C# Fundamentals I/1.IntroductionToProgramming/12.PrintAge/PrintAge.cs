//12. * Write a program to read your age from the console and print how old you will be after 10 years.

using System;

class PrintAge
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("After 10 years you will be at {0} years old!", age + 10);
    }
}

