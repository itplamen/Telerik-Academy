//4.Declare an integer variable and assign it with the value 254 in hexadecimal format. Use Windows Calculator to find 
//its hexadecimal representation.

using System;

class DeclareHexInt
{
    static void Main(string[] args)
    {
        int number = 254;
        int hexNumber = 0xFe;

        Console.WriteLine("{0} In hexadecimal format is: {1:X}", number, hexNumber);
    }
}

