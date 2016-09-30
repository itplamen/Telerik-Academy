//13.Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBits
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());

        uint p3 = 3; uint p24 = 24;
        uint p4 = 4; uint p25 = 25;
        uint p5 = 5; uint p26 = 26;

        uint bitCheck = 1;
        uint check3 = ((number >> 3) & bitCheck);
        uint check4 = ((number >> 4) & bitCheck);
        uint check5 = ((number >> 5) & bitCheck);

        uint check24 = ((number >> 24) & bitCheck);
        uint check25 = ((number >> 25) & bitCheck);
        uint check26 = ((number >> 26) & bitCheck);

        Console.WriteLine("<< Before exchange >>");
        Console.WriteLine("The number is: {0}", number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        Console.WriteLine("Bit {0} = {1}", p3, check3);
        Console.WriteLine("Bit {0} = {1}", p4, check4);
        Console.WriteLine("Bit {0} = {1}", p5, check5);

        Console.WriteLine("Bit {0} = {1}", p24, check24);
        Console.WriteLine("Bit {0} = {1}", p25, check25);
        Console.WriteLine("Bit {0} = {1}", p26, check26);

        check3 = ((number >> 24) & bitCheck);
        check4 = ((number >> 25) & bitCheck);
        check5 = ((number >> 26) & bitCheck);

        check24 = ((number >> 3) & bitCheck);
        check25 = ((number >> 4) & bitCheck);
        check26 = ((number >> 5) & bitCheck);

        uint maskFirst = 56;
        uint maskLast = 117440512;

        uint firstThreeBits = number & maskFirst;
        uint lastThreeBits = number & maskLast;

        firstThreeBits = firstThreeBits << 21;
        lastThreeBits = lastThreeBits >> 21;

        number = number & (~maskFirst);
        number = number & (~maskLast);

        number = number | firstThreeBits;
        number = number | lastThreeBits;

        Console.WriteLine("<< After exchange >>");
        Console.WriteLine("The new number is: {0}", number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        Console.WriteLine("Bit {0} = {1}", p3, check3);
        Console.WriteLine("Bit {0} = {1}", p4, check4);
        Console.WriteLine("Bit {0} = {1}", p5, check5);

        Console.WriteLine("Bit {0} = {1}", p24, check24);
        Console.WriteLine("Bit {0} = {1}", p25, check25);
        Console.WriteLine("Bit {0} = {1}", p26, check26);
    }
}

