//04. Write methods that calculate the surface of a triangle by given:
//1.Side and an altitude to it; 
//2. Three sides; 
//3. Two sides and an angle between them. 
//Use System.Math.

using System;

    class CalculateSurfaceOFTriangle
    {
        static void VariantA()
        {
            Console.Write("Enter side: ");
            double side = double.Parse(Console.ReadLine());

            Console.Write("Enter altitude: ");
            double altitude = double.Parse(Console.ReadLine());

            double surface = (side * altitude) / 2;
            Console.WriteLine("The surface of the triangle is: " + surface);
        }

        static void VariantB()
        {
            Console.Write("Enter first side: ");
            double firstSide = double.Parse(Console.ReadLine());

            Console.Write("Enter second side: ");
            double secondSide = double.Parse(Console.ReadLine());

            Console.Write("Enter third side: ");
            double thirdSide = double.Parse(Console.ReadLine());

            double semiperimeter = (firstSide + secondSide + thirdSide) / 2;
            double surface = Math.Sqrt(semiperimeter*(semiperimeter - firstSide)*(semiperimeter - secondSide)*(semiperimeter - thirdSide));
            Console.WriteLine("The surface of the triangle is: " + surface);
        }

        static void VariantC()
        {
            Console.Write("Enter first side: ");
            double firstSide = double.Parse(Console.ReadLine());

            Console.Write("Enter second side: ");
            double secondSide = double.Parse(Console.ReadLine());

            Console.Write("Enter angle: ");
            double angle = double.Parse(Console.ReadLine());

            double surface = (firstSide * secondSide * Math.Sin(Math.PI * angle / 180)) / 2;
            Console.WriteLine("The surface of the triangle is: " + surface);
        }

        static void Main()
        {
            Console.WriteLine("1. By side and altitude.");
            Console.WriteLine("2. By tree sides.");
            Console.WriteLine("3. Two sides and an angle between them. ");
            Console.Write("Enter your choise: ");
            byte userChoise = byte.Parse(Console.ReadLine());

            switch (userChoise)
            {
                case 1:
                    Console.WriteLine();
                    VariantA();
                    break;
                case 2:
                    Console.WriteLine();
                    VariantB();
                    break;
                case 3:
                    Console.WriteLine();
                    VariantC();
                    break;
                default:
                    Console.WriteLine("\nWrong choise. Try again... \n");
                    Main();
                    break;
            } 
        }
    }

