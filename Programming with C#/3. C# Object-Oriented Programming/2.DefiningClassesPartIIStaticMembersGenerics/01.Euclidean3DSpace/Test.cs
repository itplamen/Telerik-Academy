//01.Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() 
//to enable printing a 3D point.

//02.Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. 
//Add a static property to return the point O.

//03.Write a static class with a static method to calculate the distance between two points in the 3D space.

//04.Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with static 
//methods to save and load paths from a text file. Use a file format of your choice.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Euclidean3DSpace
{
    class Test
    {
        static void Main(string[] args)
        {
            Path path = new Path();

            path.AddPoint(new Point3D(1, 2, 3));
            path.AddPoint(new Point3D(6, -6, 1));
            path.AddPoint(new Point3D(1, 2, 3));
            path.AddPoint(new Point3D(5, -4, 4));
            path.AddPoint(new Point3D(8, 8, 8));
            path.AddPoint(new Point3D(-8, -8, -8));
            path.AddPoint(new Point3D(1, 1, 3));
            path.AddPoint(new Point3D(-1, 7, -3));
            path.AddPoint(new Point3D(13, 0, 3));
            path.AddPoint(new Point3D(-1, -12, -6));

            PathStorage.SavePath(path);

            Path load = PathStorage.LoadPath();

            load.PrintSequenceOfPoints();
        }
    }
}
