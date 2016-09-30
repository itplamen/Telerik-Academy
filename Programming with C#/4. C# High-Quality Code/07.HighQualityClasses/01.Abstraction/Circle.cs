namespace _01.Abstraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Circle radius cannot be negative or null!");
            }

            this.Radius = radius;
        }

        public double Radius 
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Circle's radius cannot be negative or null!");
                }

                this.radius = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
