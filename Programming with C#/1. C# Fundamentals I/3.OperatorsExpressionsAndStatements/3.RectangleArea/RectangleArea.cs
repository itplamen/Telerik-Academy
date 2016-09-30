//3. Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectangleArea
{
    static void Main(string[] args)
    {
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        double area = width * height;

        Console.WriteLine("The rectangle's area is: " + area);
    }
}

