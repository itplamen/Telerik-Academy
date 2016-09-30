using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Figures
{
    public class Rectangle : Shape
    {
        // Constructor
        public Rectangle(double width, double height)
            : base(width, height)
        {

        }

        // Methods
        // Ovveride CalculateSurface()
        public override double CalculateSurface()
        {
            double surface = Width * Height;

            return surface;
        }
    }
}
