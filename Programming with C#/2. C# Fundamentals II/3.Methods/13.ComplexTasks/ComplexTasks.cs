//13.Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//        Create appropriate methods.
//        Provide a simple text-based menu for the user to choose which task to solve.
//        Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;

    class ComplexTasks
    {
        static void TaskChoice()
        {
            Console.Write("Task number: ");
            int task = int.Parse(Console.ReadLine());

            switch (task)
            {
                case 1: NumberInput();
                    TaskContinue();
                    break;
                case 2: SequenceLength();
                    TaskContinue();
                    break;
                case 3: EquationInput();
                    TaskContinue();
                    break;
                default: Console.WriteLine("Enter a number from 1 to 3!\n");
                    TaskChoice();
                    break;
            }
        }
        static void TaskContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Do you want to solve something else? (Y/N)");
            char cont = char.Parse(Console.ReadLine());
            if (cont == 'Y' || cont == 'y')
            {
                TaskChoice();
            }
            else if (cont == 'N' || cont == 'n')
            {
                Console.WriteLine("Thank you for using the program!");
            }
            else
            {
                Console.WriteLine("Please, enter a correct answer!");
                TaskContinue();
            }
        }

        static void NumberInput()
        {
            bool pos = false;
            decimal number;
            do
            {
                Console.WriteLine("Enter a positive number!");
                number = decimal.Parse(Console.ReadLine());
                if (number > 0)
                {
                    pos = true;
                }
            }
            while (!pos);

            Reverse(number);
        }
        static void Reverse(decimal number)
        {
            string stringNumber = number.ToString();
            string[] reversedNumber = new string[stringNumber.Length];

            for (int i = stringNumber.Length - 1; i >= 0; i--)
            {
                reversedNumber[stringNumber.Length - i - 1] = stringNumber[i].ToString();
            }

            foreach (string digit in reversedNumber)
            {
                Console.Write(digit);
            }
            Console.WriteLine();
        }

        static void SequenceLength()
        {
            bool nonEmpty = false;
            int number;
            do
            {
                Console.WriteLine("Enter a how many real positive numbers will calculate!");
                number = int.Parse(Console.ReadLine());
                if (number > 0)
                {
                    nonEmpty = true;
                }
            }
            while (!nonEmpty);

            InputAndCalculation(number);
        }
        static void InputAndCalculation(int number)
        {
            Console.WriteLine("Enter the numbers:");
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Their average sum is: {0} ", (decimal)sum / number);
        }

        static void EquationInput()
        {
            bool pos = false;
            decimal a;
            do
            {
                Console.WriteLine("Enter the first number of linear equation - a>0!");
                a = decimal.Parse(Console.ReadLine());
                if (a > 0)
                {
                    pos = true;
                }
            }
            while (!pos);
            Console.WriteLine("Enter the second number of linear equation - b!");
            decimal b = decimal.Parse(Console.ReadLine());

            EquationCalculation(a, b);

        }
        static void EquationCalculation(decimal a, decimal b)
        {
            decimal x = 0;
            if (b > 0)
            {
                Console.WriteLine();
                Console.Write("Your linear equation is: {0}*X + {1} = 0\n", a, b);
                Console.WriteLine("X = {0}", x = -b / a);
            }
            else
            {
                Console.WriteLine();
                Console.Write("Your linear equation is: {0}*X - {1} = 0\n", a, Math.Abs(b));
                Console.WriteLine("X = {0}", x = b / a);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter task that you want ti sovle...");
            Console.WriteLine("1. Reverses the digits of a number\n2. Calculates the average of a sequence of integers\n"
            + "3. Solves a linear equation a * x + b = 0\n");

            TaskChoice();
        }
    }

