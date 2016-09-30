//4.Write a program that calculates N!/K! for given N and K (1<K<N).

using System;

class CalculatesFactorial
{
    static void Main()
    {
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        int result = 1;

        if (k < n)
        {
            for (int i = n; i > k; i--)
            {
                result = result * i;
            }
        }
        else
        {
            Console.WriteLine("ERROR!!! Enter again");
            Main();
        }
        Console.WriteLine(result);
    }
}

