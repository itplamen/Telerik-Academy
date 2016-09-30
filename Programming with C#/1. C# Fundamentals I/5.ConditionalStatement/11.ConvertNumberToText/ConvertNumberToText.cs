//11.* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 

//Examples:
//    0  "Zero"
//    273  "Two hundred seventy three"
//    400  "Four hundred"
//    501  "Five hundred and one"
//    711  "Seven hundred and eleven"

using System;

class ConvertNumberToText
{
    static void Main()
    {
        string[] fromZeroToNine = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        string[] fromTenToNineteen = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] fromTwentyToHundred = new string[] { "", "", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety", "Hundred" };

        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine();

        if (number >= 0 && number < 1000)
        {
            int digits = number % 10;
            int tens = (number / 10) % 10;
            int hundreds = (number / 100) % 10;

            if (hundreds != 0)
            {
                Console.Write("{0} -> {1} hundred ", number, fromZeroToNine[hundreds]);

                if (tens != 0 && tens != 1 && number >= 10)
                {
                    Console.Write("and {0}", fromTwentyToHundred[tens]);
                }
                else if (tens == 1)
                {
                    Console.Write("and {0}", fromTenToNineteen[digits]);
                }
                else
                {
                    if (digits > 0 && digits <= 9)
                    {
                        Console.Write("and {0}", fromZeroToNine[digits]);
                    }
                }
            }
            else
            {
                if (tens != 0 && tens != 1 && number >= 20)
                {
                    Console.Write("{0} ", fromTwentyToHundred[tens]);
                    Console.Write("{0} ", fromZeroToNine[digits]);
                }
                else if (tens == 1)
                {
                    Console.Write("{0} -> {1} ", number, fromTenToNineteen[digits]);
                }
                else
                {
                    Console.Write("{0} -> {1}", number, fromZeroToNine[digits]);
                }
            }
        }
        else
        {
            Console.WriteLine("ERROR, invalid number");
            Main();
        }
        Console.WriteLine();
    }
}

