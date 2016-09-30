//11.Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class IntegerExchange
{
    static void Main(string[] args)
    {
        int firstNumber = 5;
        int secondNumber = 10;
        int current = 0;

        //Print numbers before exchange
        Console.WriteLine("---------- Print numbers before exchange ----------");
        Console.WriteLine("First number: {0}, Second number: {1}", firstNumber, secondNumber);
        Console.WriteLine();

        current = firstNumber;
        firstNumber = secondNumber;
        secondNumber = current;

        //Print numbers after exchange
        Console.WriteLine("---------- Print numbers after exchange ----------");
        Console.WriteLine("First number: {0}, Second number: {1}", firstNumber, secondNumber);
    }
}
