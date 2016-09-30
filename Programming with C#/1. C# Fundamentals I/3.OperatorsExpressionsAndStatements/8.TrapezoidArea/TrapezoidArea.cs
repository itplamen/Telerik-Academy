//8.Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main(string[] args)
    {
        Console.Write("Enter side a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Eneter side b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter height h: ");
        double h = double.Parse(Console.ReadLine());

        double area = (a + b) / (2 * h);
        Console.WriteLine("The trapezoid's area is: " + area);
    }
}

