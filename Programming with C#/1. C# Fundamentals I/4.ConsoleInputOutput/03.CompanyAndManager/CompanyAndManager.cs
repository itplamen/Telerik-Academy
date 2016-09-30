//3.A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, 
//age and a phone number. Write a program that reads the information about a company and its manager and prints them on 
//the console.

using System;

class CompanyAndManager
{
    static void Main(string[] args)
    {
        //Information about company
        Console.WriteLine("---------- Information about company ----------");

        Console.Write("Name: ");
        string companyName = Console.ReadLine();

        Console.Write("Address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Phone number: ");
        int companyPhoneNumber = int.Parse(Console.ReadLine());

        Console.Write("Fax number: ");
        int companyFaxNumber = int.Parse(Console.ReadLine());

        Console.Write("Web site: ");
        string companyWebSite = Console.ReadLine();

        //Information about manager
        Console.WriteLine("\n---------- Enter information about the manager ----------");

        Console.Write("First name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Age: ");
        byte managerAge = byte.Parse(Console.ReadLine());

        Console.Write("Phone number: ");
        int managerPhoneNumber = int.Parse(Console.ReadLine());

        //Print information about company
        Console.WriteLine("\nInformation abuot company...");
        Console.WriteLine("Name: {0}, Address: {1}, Phone number: {2:000-000-0000}, Fax number: {3:000-000-0000}, Web site: {4}", companyAddress, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebSite);

        //Print information about manager
        Console.WriteLine("\nInformation about manager...");
        Console.WriteLine("First name: {0}, Last name: {1}, Age: {2}, Phone number: {3:000-000-0000}", managerFirstName, managerLastName, managerAge, managerPhoneNumber);
    }
}

