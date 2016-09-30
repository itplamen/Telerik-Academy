//12.Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that 
//prints the entire ASCII table of characters on the console.

using System;

class PrintASCII
{
    static void Main(string[] args)
    {
        for (int character = 0; character < 127; character++)
        {
            char symbol = (char)character;
            Console.WriteLine("{0} -> {1}", character, symbol);

        }
    }
}

