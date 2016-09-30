using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Euclidean3DSpace
{
    // Hold a sequence of points in the 3D space
    public class Path
    {
        public List<Point3D> sequenceOfPoints = new List<Point3D>();

        public List<Point3D> SequenceOfPoints
        {
            get { return this.sequenceOfPoints; }
            set { this.sequenceOfPoints = value; }
        }

        public void AddPoint(Point3D point)
        {
            SequenceOfPoints.Add(point);
        }

        // Print Sequence of points
        public void PrintSequenceOfPoints()
        {
            foreach (var item in sequenceOfPoints)
            {
                Console.WriteLine("{0}, {1}, {2}", item.X, item.Y, item.Z);
            }
        }
    }
}
