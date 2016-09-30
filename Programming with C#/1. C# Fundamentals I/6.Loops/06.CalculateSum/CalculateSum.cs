//6.Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

class CalculateSum
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter X: ");
        int x = int.Parse(Console.ReadLine());

        double degree;
        double factorialN = 1;
        double s = 1;

        for (int i = 1; i <= n; i++)
        {
            degree = (int)Math.Pow(x, i);
            factorialN = factorialN * i;
            s = s + factorialN / degree;
        }

        Console.WriteLine("S = 1 + 1!/X + 2!/X^2 + ... + N!/X^N  -> S= " + s);  
    }
}

