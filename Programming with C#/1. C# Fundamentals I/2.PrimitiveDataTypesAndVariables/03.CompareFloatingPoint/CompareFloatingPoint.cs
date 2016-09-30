//3.Write a program that safely compares floating-point numbers with precision of 0.000001. 
//Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

using System;

class CompareFloatingPoint
{
    static void Main(string[] args)
    {
        float precision = 0.000001f;

        double firstDouble = 5.00000001f;
        double secondDouble = 5.00000003f;
        float firstFloat = 5.3f;
        float secondFloat = 6.01f;

        bool compareOne = (Math.Abs(firstDouble - secondDouble) <= precision);
        bool compareTwo = (Math.Abs(firstFloat - secondFloat) <= precision);

        Console.WriteLine(compareOne);
        Console.WriteLine(compareTwo);
    }
}

