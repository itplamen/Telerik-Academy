//2.Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the 
//same time.

using System;

class DividedOrNo
{
    static void Main(string[] args)
    {
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());

        bool check = (number % 35 == 0);

        if (check)
        {
            Console.WriteLine("The number CAN be divided by 7 and 5 -> {0}", check);
        }
        else
        {
            Console.WriteLine("The number CAN'T be divided by 7 and 5 -> {0}", check);
        }
    }
}

