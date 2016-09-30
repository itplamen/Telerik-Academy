//04.Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;

    class ConvertHexadecimalNumberToDecimal
    {
        static void ConvertToDecimal(string hexadecimalNumber)
        {
            int decimalNumber = 0;
            int number = 0;
            int index = hexadecimalNumber.Length - 1;

            List<char> list = new List<char>();

            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                list.Add(hexadecimalNumber[i]);

                if (list[i] == 'A')
                {
                    number = 10;
                }
                else if (list[i] == 'B')
                {
                    number = 11;
                }
                else if (list[i] == 'C')
                {
                    number = 12;
                }
                else if (list[i] == 'D')
                {
                    number = 13;
                }
                else if (list[i] == 'E')
                {
                    number = 14;
                }
                else if (list[i] == 'F')
                {
                    number = 15;
                }
                else
                {
                    number = (int)Char.GetNumericValue(hexadecimalNumber[i]);
                }

                decimalNumber = decimalNumber + (number * (int)Math.Pow(16, index));
                index--;
            }

            Console.WriteLine("{0} -> {1} ", hexadecimalNumber, decimalNumber);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter hexadecimal number: ");
            string hexadecimalNumber = Console.ReadLine().ToUpper();

            ConvertToDecimal(hexadecimalNumber);
        }
    }

