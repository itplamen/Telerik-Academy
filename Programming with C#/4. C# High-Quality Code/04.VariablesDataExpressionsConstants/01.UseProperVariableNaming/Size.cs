namespace _01.UseProperVariableNaming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Size
    {
        private double width;
        private double heigth;

        public Size(double width, double heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }

        public double Width
        {
            get 
            { 
                return this.width; 
            }

            set
            {
                if (this.width <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be zero or negative!");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public double Heigth
        {
            get
            {
                return this.heigth;
            }

            set
            {
                if (this.heigth <= 0)
                {
                    throw new ArgumentOutOfRangeException("Heigth cannot be zero or negative!");
                }
                else
                {
                    this.heigth = value;
                }
            }
        }
    }
}
