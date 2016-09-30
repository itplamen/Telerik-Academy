//08. Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be 
//added could have up to 10 000 digits.

using System;
using System.Text;

class AddIntegersAsArrays
{
    static string SumTwoNumbersByDigits(string firstNumber, string secondNumber)
    {
        int[] firstArray = new int[Math.Max(firstNumber.Length, secondNumber.Length)];
        int[] secondArray = new int[Math.Max(firstNumber.Length, secondNumber.Length)];
        int[] sumArray = new int[Math.Max(firstNumber.Length, secondNumber.Length) + 1];

        StringBuilder sb = new StringBuilder();

        sb.Append(firstNumber);
        for (int i = 0; i < firstNumber.Length; i++)
        {
            firstArray[i] = Convert.ToInt32(sb[firstNumber.Length - 1 - i].ToString());
        }

        sb.Clear();
        sb.Append(secondNumber);
        for (int i = 0; i < secondNumber.Length; i++)
        {
            secondArray[i] = Convert.ToInt32(sb[secondNumber.Length - 1 - i].ToString());
        }

        sb.Clear();
        int number = 0;
        for (int i = 0; i < Math.Max(firstNumber.Length, secondNumber.Length) + 1; i++)
        {
            if (i == 0)
            {
                sumArray[i] = (firstArray[i] + secondArray[i]) % 10;
            }
            else if (i == Math.Max(firstNumber.Length, secondNumber.Length))
            {
                sumArray[i] = (firstArray[i - 1] + secondArray[i - 1]) / 10;
            }
            else
            {
                sumArray[i] = (firstArray[i] + secondArray[i]) % 10 + (firstArray[i - 1] + secondArray[i - 1]) / 10 + number;
                number = 0;
                if (sumArray[i] > 9)
                {
                    number = sumArray[i] / 10;
                    sumArray[i] = sumArray[i] % 10;
                }
            }
        }

        Array.Reverse(sumArray);
        if (sumArray[0] != 0)
        {
            sb.Append(sumArray[0]);
        }
        for (int i = 1; i < Math.Max(firstNumber.Length, secondNumber.Length) + 1; i++)
        {
            sb.Append(sumArray[i]);
        }
        return sb.ToString();
    }

    static void Main(string[] args)
    {
        Console.Write("Enter first number:");
        string firstNumber = Console.ReadLine();

        Console.Write("Enter second number:");
        string secondNumber = Console.ReadLine();

        string result = SumTwoNumbersByDigits(firstNumber, secondNumber);
        Console.WriteLine(result);
    }
}


