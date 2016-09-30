//9.Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the 
//rectangle R(top=1, left=-1, width=6, height=2).

using System;

class CheckPointInCircleOutOfRectangle
{
    static void Main(string[] args)
    {
        Console.Write("Enter point x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter point y: ");
        double y = double.Parse(Console.ReadLine());

        if (((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9)
        {
            Console.WriteLine("The point is in the circle");
            if ((x < (-1)) || (x > 5))
            {
                Console.WriteLine("The point is outside the rectangle");
            }
            else if (y > 1 || y < (-1))
            {
                Console.WriteLine("The point is outside the rectangle");
            }
            else if (((x > (-1)) || (x < 5)) && (y < 1 || y > (-1)))
            {
                Console.WriteLine("The point is IN the rectangle");
            }
        }
        else
        {
            Console.WriteLine("The point is OUT the circle");
            if ((x < (-1)) || (x > 5))
            {
                Console.WriteLine("The point is outside the rectangle");
            }
            else if (y > 1 || y < (-1))
            {
                Console.WriteLine("The point is outside the rectangle");
            }
            else if (((x > (-1)) || (x < 5)) && (y < 1 || y > (-1)))
            {
                Console.WriteLine("The point is IN the rectangle");
            }
        }
    }
}

