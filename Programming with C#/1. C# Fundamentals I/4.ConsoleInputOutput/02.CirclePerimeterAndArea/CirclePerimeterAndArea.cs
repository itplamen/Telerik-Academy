//2.Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class CirclePerimeterAndArea
{
    static void Main(string[] args)
    {
        Console.Write("Enter radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("\nThe circle's perimeter is: {0}", 2 * Math.PI * radius);
        Console.WriteLine("\nThe circle's area is: {0}\n", Math.PI * radius * radius);
    }
}

