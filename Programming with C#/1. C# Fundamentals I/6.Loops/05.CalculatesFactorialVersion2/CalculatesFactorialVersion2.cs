//5.Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;

class CalculatesFactorialVersion2
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        int factorialN = 1;
        int factorialK = 1;
        int factorialKminusN = 1;

        if (n < k)
        {
            for (int i = 0; i < (k - n); i++)
            {
                factorialKminusN = factorialKminusN * ((k - n) - i);
            }
            while (true)
            {
                if (k == 1)
                {
                    break;
                }
                factorialK *= k;
                k--;
            }

            while (true)
            {
                if (n == 1)
                {
                    break;
                }
                factorialN *= n;
                n--;
            }

            int result = (factorialK * factorialN) / factorialKminusN;
            Console.WriteLine("N!*K! / (K-N)! =  " + result);
        }
        else
        {
            Console.WriteLine("ERROR!!! Enter again...");
            Main();
        }
    }
}

