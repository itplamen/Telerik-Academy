using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Figures
{
    public class Circle : Shape
    {
        // Constructor
        public Circle(double radius)
            : base(radius, radius)
        {
            
        }

        // Methods
        // Ovveride CalculateSurface()
        public override double CalculateSurface()
        {
            double surface = Math.PI * (this.Width / 2.0) * (this.Height / 2.0);
            return surface;
        }
    }
}
