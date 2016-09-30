//10.Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class SumAccuracy
{
    static void Main(string[] args)
    {
        double number = 1;
        double sum = 1;

        Console.WriteLine(number);

        for (double j = 2; j <= 1000; j++)
        {
            number = 1;
            if (j % 2 == 0)
            {
                number = number / j;
            }
            else
            {
                number = -(number / j);
            }
            Console.WriteLine(number);

            sum = sum + number;
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}

