//10.Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a 
//number represented as array of digits by given integer number. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CalculateFactorial
{
    static string Calculate(int n)
    {
        string finalResult = "1";

        for (int i = 2; i <= n; i++)
        {
            finalResult = Multiply(finalResult, i);
        }
        return finalResult;
    }

    static string Multiply(string numberOne, int numberTwo)
    {
        List<int> digits = GetDigits(numberOne);

        StringBuilder sb = new StringBuilder();
        int number = 0;

        for (int index = 0; index < digits.Count; index++)
        {
            int digitResult = digits[index] * numberTwo;
            digitResult += number;

            if (digitResult < 10)
            {
                sb.Insert(0, digitResult);
                number = 0;
            }
            else if (digitResult >= 10)
            {
                sb.Insert(0, digitResult % 10);
                number = digitResult / 10;
            }
        }

        if (number > 0)
        {
            sb.Insert(0, number);
        }
        string endResult = Convert.ToString(sb);
        return endResult;
    }

    static List<int> GetDigits(string number)
    {
        List<int> digits = new List<int>();

        for (int i = number.Length - 1; i >= 0; i--)
        {
            digits.Add(int.Parse(Convert.ToString(number[i])));
        }
        return digits;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());

        string factorial = Calculate(n);

        Console.WriteLine("{0}! = {1}", n, factorial);
    }
}

