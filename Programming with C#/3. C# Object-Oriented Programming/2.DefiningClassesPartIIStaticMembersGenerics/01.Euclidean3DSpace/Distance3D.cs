using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Euclidean3DSpace
{
    public static class Distance3D
    {
        // Calculate distance between two points in the 3D space
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double firstCurrentDistance = (firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X);
            double secondCurrentDistance = (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y);
            double thirdcurrentDistance = (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z);
            double distance = Math.Sqrt(firstCurrentDistance + secondCurrentDistance + thirdcurrentDistance);

            return distance;
        }
    }
}
