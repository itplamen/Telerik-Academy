//10.Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has 
//value of 1. Example: v=5; p=1  false.

using System;

class BitPositionCheck
{
    static void Main(string[] args)
    {
        Console.Write("Enter some integer number: ");
        int v = int.Parse(Console.ReadLine());

        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());

        bool check = ((v >> p) & 1) == 1;

        if (check == true)
        {
            Console.WriteLine("The bit is 1 -> {0}", check);
        }
        else
        {
            Console.WriteLine("The bit is 0 -> {0}", check);
        }
    }
}

