//6.Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class PointWithinCircle
{
    static void Main(string[] args)
    {
        Console.Write("Enter point X: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Entee point Y: ");
        double y = double.Parse(Console.ReadLine());

        double radius = 5; 

        if (x * x + y * y <= radius * radius)
        {
            Console.WriteLine("The point ({0},{1}) is in the circle", x, y);
        }
        else
        {
            Console.WriteLine("The point ({0},{1}) is NOT in circle", x, y);
        }
    }
}

