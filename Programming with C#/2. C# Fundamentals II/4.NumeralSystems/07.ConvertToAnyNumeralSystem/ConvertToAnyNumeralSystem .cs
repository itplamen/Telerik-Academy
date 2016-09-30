//07. Write a program to convert from any numeral system of given base s to any other numeral system 
//of base d (2 ≤ s, d ≤  16).

using System;
using System.Collections.Generic;

class ConvertToAnyNumeralSystem
{
    static int ConvertToDecimal(string number, int s, int d)
    {
        int index = number.Length - 1;
        int decimalNumber = 0;
        int degree = 0;

        if ((s == 2) || (s == 8))
        {
            degree = s;
            for (int i = 0; i < number.Length; i++)
            {
                int value = (int)Char.GetNumericValue(number[i]);
                decimalNumber = decimalNumber + (value * (int)Math.Pow(degree, index));
                index--;
            }
        }

        if (s == 16)
        {
            int value = 0;
            List<char> list = new List<char>();
            for (int i = 0; i < number.Length; i++)
            {
                list.Add(number[i]);

                if (list[i] == 'A')
                {
                    value = 10;
                }
                else if (list[i] == 'B')
                {
                    value = 11;
                }
                else if (list[i] == 'C')
                {
                    value = 12;
                }
                else if (list[i] == 'D')
                {
                    value = 13;
                }
                else if (list[i] == 'E')
                {
                    value = 14;
                }
                else if (list[i] == 'F')
                {
                    value = 15;
                }
                else
                {
                    value = (int)Char.GetNumericValue(number[i]);
                }

                decimalNumber = decimalNumber + (value * (int)Math.Pow(16, index));
                index--;
            }
        }
        return decimalNumber;
    }

    static void ConvertNumber(string number, int s, int d)
    {
        int decimalNumber = ConvertToDecimal(number, s, d);
        
        List<int> result = new List<int>();
        int degree = 0;

        if ((d == 2) || (d == 8))
        {
            degree = d;
            int value = Convert.ToInt32(decimalNumber);
            while (value > 0)
            {
                result.Add(value % degree);
                value /= degree;
            }

            result.Reverse();
            foreach (int element in result)
            {
                Console.Write(element);
            }
            Console.WriteLine();
        }

        if (d == 16)
        {
            string overage = "";
            List<string> hexadecimalNumber = new List<string>();

            while (decimalNumber > 0)
            {
                overage = "" + decimalNumber % 16;

                if (overage == "10")
                {
                    overage = "A";
                }
                if (overage == "11")
                {
                    overage = "B";
                }
                if (overage == "12")
                {
                    overage = "C";
                }
                if (overage == "13")
                {
                    overage = "D";
                }
                if (overage == "14")
                {
                    overage = "E";
                }
                if (overage == "15")
                {
                    overage = "F";
                }

                hexadecimalNumber.Add("" + overage);
                overage = "";
                decimalNumber = decimalNumber / 16;
            }

            hexadecimalNumber.Reverse();
            foreach (string element in hexadecimalNumber)
            {
                Console.Write(element);
            }
            Console.WriteLine();
        }
        if (d == 10)
        {
            Console.WriteLine("The decimal number is: " + decimalNumber);
        }
    }

    static void Main()
    {
        Console.Write("Enter numeral system from you want to convert: ");
        int s = int.Parse(Console.ReadLine());

        Console.Write("Enter number: ");
        string number = Console.ReadLine().ToUpper();

        Console.Write("Enter numeral system to you want to convert: ");
        int d = int.Parse(Console.ReadLine());

        ConvertNumber(number, s, d);
    }
}

        
    

