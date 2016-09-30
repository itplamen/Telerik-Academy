//9.Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the 
//Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.

using System;
using System.Text;

class TriangleOfCopyrightSymbols
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        char symbol = '\u00a9';
        int rows = 3;
        int columns = 5;
        int character = 1;
        for (int i = 0; i < rows; i++)
        {
            for (int space = 0; space < columns - i; space++)
            {
                Console.Write("  ");
            }
            for (int s = 0; s < character; s++)
            {
                Console.Write(symbol);
            }
            character += 2;
            Console.WriteLine();
        }
    }
}

