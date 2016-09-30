//1.Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main(string[] args)
    {
        Console.Write("Enter some integer number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even!");
        }
        else
        {
            Console.WriteLine("The number is odd!");
        }
    }
}

