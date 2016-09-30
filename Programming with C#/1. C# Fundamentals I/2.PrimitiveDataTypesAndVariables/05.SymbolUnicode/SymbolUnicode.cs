//5.Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows 
//Calculator to find the hexadecimal representation of 72.

using System;

class SymbolUnicode
{
    static void Main(string[] args)
    {
        char symbol = '\u0048';
        Console.WriteLine("The symbol that has Unicode code {0} is {1}", (int)symbol, symbol);
    }
}

