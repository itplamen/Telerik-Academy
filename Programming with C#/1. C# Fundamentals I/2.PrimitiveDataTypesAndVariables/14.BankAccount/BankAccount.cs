//14.A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank 
//name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed to keep the 
//information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccount
{
    static void Main(string[] args)
    {
        string firstName = "Plamen";
        string middleName = "Svetlozarov";
        string lastName = "Georgiev";

        decimal balance = 9234092374923217301237.7M;
        string bankName = "OTP Bank";
        string iban = "BG79UBBS921*****1039123";
        string bicCode = "79UBBS";

        ulong creditCard1 = 2139123131;
        ulong creditCard2 = 2313122233;
        ulong creditCard3 = 3123333333;

        //Print information about bank account
        Console.WriteLine("<< Account information >>\n\n");

        Console.WriteLine("First name:{0}\nMiddle name:{1}\nLast name:{2}\n", firstName, middleName, lastName);
        Console.WriteLine("Balance:{0}\nBank:{1}\nIBAN:{2}\nBIC:{2}\n", balance, bankName, iban, bicCode);
        Console.WriteLine("Credit card's number: {0}, {1}, {2}\n", creditCard1, creditCard2, creditCard3);
    }
}

