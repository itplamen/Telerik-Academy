//03. Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;


    class ConvertDecimalNumberToHexadecimal
    {
        static void ConvertToHexadecimal(int decimalNumber)
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

        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            ConvertToHexadecimal(decimalNumber);
        }
    }

