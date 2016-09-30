//13.Create a program that assigns null values to an integer and to double variables. Try to print them on the console, 
//try to add some values or the null literal to them and see the result.

using System;

class NullableVariables
{
    static void Main(string[] args)
    {
        int? intNumber = null;
        double? doubleNumber = null;

        //Print numbers before assigns them with values
        Console.WriteLine(" ---------- Print numbers before assigns them with values ----------");
        Console.WriteLine("Int number: {0} \nDouble number: {1}", intNumber, doubleNumber);
        Console.WriteLine();

        intNumber = 10;
        doubleNumber = 10.10110111;

        //Print numbers after assigns them with values
        Console.WriteLine(" ---------- Print numbers after assigns them with values ----------");
        Console.WriteLine("Int number: {0} \nDouble number: {1}", intNumber, doubleNumber);
    }
}

