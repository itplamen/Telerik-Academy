//5.Write program that asks for a digit and depending on the input shows the name of that digit (in English)
//using a switch statement.

using System;

class DigitName
{
    static void Main()
    {
        Console.Write("Enter digit (0 .. 9) : ");
        byte digit = byte.Parse(Console.ReadLine());

        switch (digit)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eighth");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            default:
                Console.WriteLine("ERROR. Digit must be in the interval (0 .. 9). Enter digit again...\n");
                Main();
                break;
        }
    }
}

