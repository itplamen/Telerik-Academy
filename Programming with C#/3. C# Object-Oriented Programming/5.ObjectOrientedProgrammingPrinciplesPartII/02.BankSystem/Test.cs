//02.A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
//Customers could be individuals or companies.

//All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed to deposit and 
//with draw money. Loan and mortgage accounts can only deposit money.

//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated 
//as follows: number_of_months * interest_rate.

//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held 
//by a company.

//Deposit accounts have no interest if their balance is positive and less than 1000.

//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.

//Your task is to write a program to model the bank system by classes and interfaces. You should identify the classes, 
//interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden
//methods.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    class Test
    {
        // Print information abount accoints
        static void Print(Account[] account)
        {
            // Print information about loand account
            foreach (var element in account)
            {
                Console.WriteLine("Type: " + element.Customer.CustomerType);
                Console.WriteLine("Name: " + element.Customer.FullName);
                Console.WriteLine("Address: " + element.Customer.Address);
                Console.WriteLine("Telephone number: " + element.Customer.PhoneNumber);
                Console.WriteLine("Interest amount: " + element.InterestAmount(9));
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            // Array of deposit accounts
            Account[] depositAccount = new Account[]
            {
                new DepositAccount(new Customer(CustomerType.Individuals, "Plamen Georgiev", "Kozloduy", "0899033011"), 100M, 2M),
                new DepositAccount(new Customer(CustomerType.Companies, "M-tel", "Sofia", "*88"), 10000M, 12M),
                new DepositAccount(new Customer(CustomerType.Companies, "Apple", "California, USA", "555-123-123"), 50000M, 3M)
            };

            // Array of loan accounts
            Account[] loanAccont = new Account[]
            {
                new LoanAccount(new Customer(CustomerType.Companies, "Vivacom", "Sofia", "02/55113"), 400M, 1M),
                new LoanAccount(new Customer(CustomerType.Individuals, "Pesho Peshov", "Ruse", "033-12-3"), 1M, 2M),
                new LoanAccount(new Customer(CustomerType.Individuals, "Iva Ivanova", "Varna", "044-22-4"), 155M, 11M)
            };

            // Array of mortgage accounts
            Account[] mortgageAccount = new Account[]
            {
                new MortgageAccount(new Customer(CustomerType.Individuals, "Kiro Kirov", "Madrid", "044-44-44"), 1500M, 10M),
                new MortgageAccount(new Customer(CustomerType.Individuals, "Penka Todorova", "Burgas", "08855123"), 444M , 2M),
                new MortgageAccount(new Customer(CustomerType.Companies, "Globul", "Sofia", "011-23-3"), 111M , 1M)
            };

            // Calling Print() method
            Console.WriteLine("---------- Deposit accounts ----------");
            Print(depositAccount);

            Console.WriteLine("---------- Loan accounts ----------");
            Print(loanAccont);

            Console.WriteLine("---------- Mortgage accounts ----------");
            Print(mortgageAccount);

            // Calculate deposit and withdraw for some accounts
            Console.WriteLine("---------- Mitko deposit accounts ----------");
            DepositAccount mitkoDepositeAccount = new DepositAccount(new Customer(CustomerType.Individuals, "Mitko Mitkov", "Pleven", "044-2222-2"), 500M, 12M);
            mitkoDepositeAccount.Deposit(111M);
            mitkoDepositeAccount.WithDraw(11M);
            Console.WriteLine("Mitko balance: " + mitkoDepositeAccount.Balance);
            Console.WriteLine();

            Console.WriteLine("---------- Asus loan accounts ----------");
            LoanAccount asusLoanAccount = new LoanAccount(new Customer(CustomerType.Companies, "ASUS", "Taiwan", "000111"), 199900M, 14M);
            asusLoanAccount.Deposit(1313M);
            Console.WriteLine("ASUS balande: " + asusLoanAccount.Balance);
            Console.WriteLine();

            Console.WriteLine("---------- Lenovo mortgage accounts ----------");
            MortgageAccount lenovoMortgageAccount = new MortgageAccount(new Customer(CustomerType.Companies, "LENOVO", "China", "0991100"), 33333M, 100M);
            lenovoMortgageAccount.Deposit(10000M);
            Console.WriteLine("Lenovo balance: " + lenovoMortgageAccount.Balance);
            Console.WriteLine();
        }
    }
}
