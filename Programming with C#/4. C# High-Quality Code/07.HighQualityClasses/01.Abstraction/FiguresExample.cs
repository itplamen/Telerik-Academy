//01.Take the VS solution "Abstraction" and refactor its code to provide good abstraction. Move the properties and methods from 
//the class Figure to their correct place. Move the common methods to the base class's interface. 
//Remove all duplicated code (properties / methods / other code).

//02.Establish good encapsulation in the classes from the VS solution "Abstraction". Ensure that incorrect values cannot be assigned 
//in the internal state of the classes.

namespace _01.Abstraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FiguresExample
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine("I am a circle.");
            Console.WriteLine("My perimeter is {0:f2}. My surface is {1:f2}.", circle.CalculatePerimeter(), circle.CalculateSurface());
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(2, 3);
            Console.WriteLine("I am a rectangle.");
            Console.WriteLine("My perimeter is {0:f2}. My surface is {1:f2}.", rectangle.CalculatePerimeter(), rectangle.CalculateSurface());
            Console.WriteLine();
        }
    }
}
