//11.Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

using System;

class ExtractBitValue
{
    static void Main(string[] args)
    {
        Console.Write("Enter some integer number: ");
        int i = int.Parse(Console.ReadLine());

        Console.Write("Enter some bit number: ");
        int b = int.Parse(Console.ReadLine());

        int check = ((i >> b) & 1);

        if (check == 1)
        {
            Console.WriteLine("The value is: " + check);
        }
        else
        {
            Console.WriteLine("The value is: " + check);
        }
    }
}

