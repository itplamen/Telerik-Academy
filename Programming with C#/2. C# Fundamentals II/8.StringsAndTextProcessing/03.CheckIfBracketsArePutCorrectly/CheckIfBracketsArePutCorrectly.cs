//03.Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

using System;
using System.Text;

    class CheckIfBracketsArePutCorrectly
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some expression: ");
            string expression = Console.ReadLine();

            int counter = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    counter++;
                }
                if (expression[i] == ')')
                {
                    counter--;
                }
                if (counter < 0)
                {
                    break;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Correct expression!");
            }
            else
            {
                Console.WriteLine("Incorrect expression!");
            }
        }
    }

