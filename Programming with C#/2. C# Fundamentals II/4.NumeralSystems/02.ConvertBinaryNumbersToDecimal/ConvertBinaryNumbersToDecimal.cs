//02. Write a program to convert binary numbers to their decimal representation.

using System;

    class ConvertBinaryNumbersToDecimal
    {
        static void ConvertToDecimal(string binaryNumber)
        {
            int index = binaryNumber.Length - 1;
            int decimalNumber = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[i] == '1')
                {
                    decimalNumber = decimalNumber + (1 * (int)Math.Pow(2, index));
                }
                index--;
            }
            Console.WriteLine("\n{0} -> {1}",binaryNumber, decimalNumber);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter binary number: ");
            string binaryNumber = Console.ReadLine();

            ConvertToDecimal(binaryNumber);
        }
    }

