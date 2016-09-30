namespace _02.CohesionAndCoupling
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Parallelepiped
    {
        private double width;
        private double height;
        private double depth;

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
                    throw new ArgumentOutOfRangeException("Width cannot be negative or zero!");
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
                    throw new ArgumentOutOfRangeException("Height canoot be negative or zero!");
                }

                this.height = value;
            }
        }

        public double Depth 
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Depth cannot be negative or zero!");
                }

                this.depth = value;
            }
        }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = GeometryUtils.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = GeometryUtils.CalcDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = GeometryUtils.CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = GeometryUtils.CalcDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }
    }
}
