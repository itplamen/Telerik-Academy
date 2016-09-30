using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Figures
{
    public class Triangle : Shape
    {
        // Constructor
        public Triangle(double width, double height)
            : base(width, height)
        {

        }
        
        // Methods
        // Ovveride CalculateSurface()
        public override double CalculateSurface()
        {
            double surface = (Width * Height) / 2;

            return surface;
        }
    }
}
