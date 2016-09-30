//01. Refactor the following code to use proper variable naming and simplified expressions:

namespace _01.UseProperVariableNaming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Test
    {
        public static Size GetRotatedSize(Size size, double rotationAngle)
        {
            var rotatedCosWidthSize  = Math.Abs(Math.Cos(rotationAngle)) * size.Width;
            var rotatedSinHeightSize  = Math.Abs(Math.Sin(rotationAngle)) * size.Heigth;
            var rotatedWidthSize = rotatedCosWidthSize + rotatedSinHeightSize;

            var rotatedSinWidthSize = Math.Abs(Math.Sin(rotationAngle)) * size.Width;
            var rotatedCosHeigthSize = Math.Abs(Math.Cos(rotationAngle)) * size.Heigth;
            var rotatedHeigthSize = rotatedSinWidthSize + rotatedCosHeigthSize;

            return new Size(rotatedWidthSize, rotatedHeigthSize);
        }

        public static void Main(string[] args)
        {
            Size size = new Size(14.4, 55.123);
            Size result = Test.GetRotatedSize(size, 5.1);

            Console.WriteLine("Width: " + result.Width);
            Console.WriteLine("Heigth: " + result.Heigth);
        }
    }
}
