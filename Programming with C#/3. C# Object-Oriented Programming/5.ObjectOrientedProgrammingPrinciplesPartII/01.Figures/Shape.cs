using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Figures
{
    public abstract class Shape
    {
        // Fields
        private double width;
        private double height;
        
        // Constructor
        public Shape(double width, double height)
        {      
            this.width = width;
            this.height = height;
        }

        // Properties
        public double Width 
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be negative or zero!");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public double Height 
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be negative or zero!");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        // Methods
        public abstract double CalculateSurface();
    }
}
