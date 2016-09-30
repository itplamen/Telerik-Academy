//10.A marketing firm wants to keep record of its employees. Each record would have the following 
//characteristics – first name, family name, age, gender (m or f), ID number, unique employee number 
//(27560000 to 27569999). Declare the variables needed to keep the information for a single employee 
//using appropriate data types and descriptive names.

using System;

class FirmRecord
{
    //Print information about employee
    static void Print(string firstName, string familyName, byte age, char gender, int IDnumber, uint employeeNumber)
    {
        Console.WriteLine("---------- Information about employee ----------");
        Console.WriteLine("Name: {0} {1}", firstName, familyName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("ID number: " + IDnumber);
        Console.WriteLine("Employee number: " + employeeNumber);
    }

    static void Main(string[] args)
    {
        string firstName = "";
        string familyName = "";
        byte age = 0;
        char gender = ' ';
        int IDnumber = 0;
        uint employeeNumber = 0;

        Console.Write("First name: ");
        firstName = Console.ReadLine();

        Console.Write("Family name: ");
        familyName = Console.ReadLine();

        Console.Write("Age: ");
        age = byte.Parse(Console.ReadLine());

        Console.Write("Gender (m or f): ");
        gender = char.Parse(Console.ReadLine());

        //Check if gender is 'm' or 'f'
        if (gender != 'm' && gender != 'f')
        {
            while (gender != 'm' && gender != 'f')
            {
                Console.Write("ERROR. Gender must be 'm' or 'f'. Enter gender again: ");
                gender = char.Parse(Console.ReadLine());
            }
        }

        Console.Write("ID number: ");
        IDnumber = int.Parse(Console.ReadLine());

        //Check employee number
        Console.Write("Unique employee number (27560000 - 27569999): ");
        employeeNumber = uint.Parse(Console.ReadLine());

        if (employeeNumber < 27560000 || employeeNumber > 27569999)
        {
            while (employeeNumber < 27560000 || employeeNumber > 27569999)
            {
                Console.Write("ERROR. Employee number must be in range (27560000 - 27569999). Enter again: ");
                employeeNumber = uint.Parse(Console.ReadLine());
            }  
        }
        Console.WriteLine();
        
        Print(firstName, familyName, age, gender, IDnumber, employeeNumber);
    }
}

