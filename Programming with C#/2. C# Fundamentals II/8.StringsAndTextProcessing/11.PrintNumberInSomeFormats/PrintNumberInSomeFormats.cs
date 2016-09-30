//11.Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. 
//Format the output aligned right in 15 symbols.

using System;


    class PrintNumberInSomeFormats
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some number : ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Decimal : {0,15:d}", number);
            Console.WriteLine("Hexadecimal : {0,15:x4}", number);
            Console.WriteLine("Percent : {0,15:p}", number);
            Console.WriteLine("Scientific : {0,15:e}", number);

            Console.WriteLine();
        }
    }

