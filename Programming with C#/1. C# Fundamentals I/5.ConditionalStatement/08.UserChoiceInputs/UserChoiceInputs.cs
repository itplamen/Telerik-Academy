//8.Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer 
//or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of 
//that variable as a console output. Use switch statement.

using System;

class UserChoiceInputs
{
    static void Main()
    {
        Console.Write("Enter choice [0, 1 or 2]: ");
        byte userChoice = byte.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 0:
                Console.Write("Enter value: ");
                int intValue = int.Parse(Console.ReadLine());
                intValue++;
                Console.WriteLine("Your new value is: " + intValue);
                break;
            case 1:
                Console.Write("Enter value: ");
                double doubleValue = double.Parse(Console.ReadLine());
                doubleValue++;
                Console.WriteLine("Your new value is: " + doubleValue);
                break;
            case 2:
                Console.Write("Enter value: ");
                string stringValue = Console.ReadLine();
                stringValue += "*";
                Console.WriteLine("Your new value is: " + stringValue);
                break;
            default: Console.WriteLine("You have entere a INCORECT choice! Try again... \n");
                Main();
                break;
        }       
    }
}

