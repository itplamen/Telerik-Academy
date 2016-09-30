//4.Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class IsThirdDigitOfInteger7
{
    static void Main(string[] args)
    {
        Console.Write("Enter some integer number: ");
        int number = int.Parse(Console.ReadLine());

        bool check = (number / 100 ) % 10 == 7;

        if (check == true)
        {
            Console.WriteLine("{0} -> The third digit IS 7!", check);
        }
        else
        {
            Console.WriteLine("{0} -> The third digit IS NOT 7!", check);
        }
    }
}

