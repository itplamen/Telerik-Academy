namespace _01.Abstraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Rectangle : Figure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException("Rectangle's width cannot be negative or null!");
            }

            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException("Rectangle's width cannot be negative or null!");
            }

            this.Width = width;
            this.Height = height;
        }

        public double Width 
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Rectangle's width cannot be negative or null!");
                }

                this.width = value;
            }
        }

        public double Height 
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Rectangle's height cannot be negative or null!");
                }

                this.height = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
