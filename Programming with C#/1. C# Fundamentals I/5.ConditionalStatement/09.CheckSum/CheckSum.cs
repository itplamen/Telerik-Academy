//9.We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. 
//Example: 3, -2, 1, 1, 8  1+1-2=0.

using System;

class CheckSum
{
    static void Main(string[] args)
    {
        int sum;
        int bitCheck = 1;
        bool result = false;

        int[] number = new int[6];

        for (int i = 1; i < 6; i++)
        {
            Console.Write("Enter number {0}:  ", i);
            number[i] = int.Parse(Console.ReadLine());
        }
        
        for (int j = 1; j < Math.Pow(2, 5); j++)
        {
            sum = 0;

            for (int position = 1; position < 6; position++)
            {

                bool isBitOne = (((j >> position) & bitCheck) == 1);


                if (isBitOne == true)
                {
                    sum += number[position];
                }

            }
            if (sum == 0)
            {
                result = true;
            }
        }
        if (result)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

