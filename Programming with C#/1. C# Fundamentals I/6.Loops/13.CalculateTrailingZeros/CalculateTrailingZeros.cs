//13.Write a program that calculates for given N how many trailing zeros present at the end of the number N!. 
//Examples:
//    N = 10  N! = 3628800  2
//    N = 20  N! = 2432902008176640000  4

//    Does your program work for N = 50 000?
//    Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!

using System;
using System.Numerics;

class CalculateTrailingZeros
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        BigInteger factorialN = 1;
        for (int i = 1; i <= number; i++)
        {
            factorialN = factorialN * i;
        }

        Console.WriteLine("N! = " + factorialN);

        string convertFactorialN = Convert.ToString(factorialN);
        int counter = 0;

        for (int i = convertFactorialN.Length - 1; i >= 0; i--)
        {
            if (convertFactorialN[i] == '0')
            {
                counter++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("The number of zero's are: " + counter);
    }
}

