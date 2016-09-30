//2.Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
//34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

class AssignedToFloatAndDouble
{
    static void Main(string[] args)
    {
        double doubleNum = 34.567839023D;
        float floatNum = 12.345F;
        double secondDoubleNum = 8923.1234857;
        float secondFloatNum = 3456.091F;

        Console.WriteLine("Assigned to float values: {0} and {1}", floatNum, secondFloatNum);
        Console.WriteLine("Assigned to double values: {0} and {1}", doubleNum, secondDoubleNum);
    }
}

