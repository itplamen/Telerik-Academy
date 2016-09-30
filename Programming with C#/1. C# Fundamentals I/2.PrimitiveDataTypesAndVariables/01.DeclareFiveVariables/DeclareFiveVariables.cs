//1.Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, 
//uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.

using System;

class DeclareFiveVariables
{
    static void Main(string[] args)
    {
        ushort uShortNum = 52130;
        sbyte sByteNum = -115;
        int intNum = 4825932;
        byte byteNum = 97;
        short sShortNum = -10000;

        Console.WriteLine("ushort: {0} \nsbyte: {1} \nint: {2} \nbyte: {3} \nshort: {4}", uShortNum, sByteNum, intNum, byteNum, sShortNum);
    }
}

