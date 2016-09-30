//01.Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of 
//the figure (height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable constructor 
//so that at initialization height must be kept equal to width and implement the CalculateSurface() method. 
//Write a program that tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) 
//stored in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Figures
{
    class Test
    {
        static void Main(string[] args)
        {
            // Array of shapes
            Shape[] shapes = new Shape[]
            {
                new Triangle(9.11, 5.1),
                new Rectangle(11, 11),
                new Circle(6.6)
            };

            // Calculate surface for different shapes
            foreach (Shape element in shapes)
            {
                Console.WriteLine("{0}= {1}", element.GetType().Name, element.CalculateSurface());
            }
        }
    }
}
