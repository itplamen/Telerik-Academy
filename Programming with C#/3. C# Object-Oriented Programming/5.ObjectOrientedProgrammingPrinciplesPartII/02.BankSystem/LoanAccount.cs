using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    public class LoanAccount : Account, IDepositable
    {
        // Constructor
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        // Methods
        // Deposit money
        public void Deposit(decimal depositMoney)
        {
            if (depositMoney <= 0M)
            {
                throw new ArgumentException("Deposit money cannot be negative or zero!");
            }
            else
            {
                this.Balance += depositMoney;
            }
        }

        // Override InterestAmount method from Account.cs
        public override decimal InterestAmount(int numberOfMonths)
        {
            if (Customer.CustomerType == CustomerType.Individuals)
            {
                if (numberOfMonths <= 3 && numberOfMonths >= 1)
                {
                    return 0;
                }
                else if (numberOfMonths > 3)
                {
                    return base.InterestRate * (numberOfMonths - 3);
                }
                else
                {
                    throw new ArgumentException("Number of months cannot be negative or zero!");
                }
            }
            else if (Customer.CustomerType == CustomerType.Companies)
            {
                if (numberOfMonths <= 2 && numberOfMonths >= 1)
                {
                    return 0;
                }
                else if (numberOfMonths > 2)
                {
                    return base.InterestRate * (numberOfMonths - 2);
                }
                else
                {
                    throw new ArgumentException("Number of months cannot be negative or zero!");
                }
            }
            else
            {
                throw new ArgumentException("Incorrect customer type!");
            }
        }
    }
}
