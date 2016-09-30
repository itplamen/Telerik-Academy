using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Euclidean3DSpace
{
    public struct Point3D 
    {
        // Fields
        private double x;
        private double y;
        private double z;

        // Field to hold the start of the coordinate system
        private static readonly Point3D startCoordinate = new Point3D(0, 0, 0);

        // Properties
        public double X 
        {
            get { return this.x; }
            set { this.x = value; } 
        }

        public double Y 
        {
            get { return this.y; }
            set { this.y = value; } 
        }

        public double Z 
        {
            get { return this.z; }
            set { this.z = value; } 
        }

        public static Point3D StartCoordinate 
        {
            get { return startCoordinate; } 
        }

        // Constructor
        public Point3D(double x, double y, double z) : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Method
        // Print 3D point
        public override string ToString()
        {
            Console.WriteLine("{0}, {1}, {2}", X, Y, Z);
            return base.ToString();
        }
    }
}
