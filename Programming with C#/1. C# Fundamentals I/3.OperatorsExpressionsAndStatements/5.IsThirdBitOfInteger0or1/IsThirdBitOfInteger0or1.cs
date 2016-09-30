//5.Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class IsThirdBitOfInteger0or1
{
    static void Main(string[] args)
    {
        Console.Write("Enter some integer number: ");
        int number = int.Parse(Console.ReadLine());

        int check = number & 8;

        if (check == 8)
        {
            Console.WriteLine("The third bit is 1");
        }
        else
        {
            Console.WriteLine("The third bit is 0");
        }
    }
}

