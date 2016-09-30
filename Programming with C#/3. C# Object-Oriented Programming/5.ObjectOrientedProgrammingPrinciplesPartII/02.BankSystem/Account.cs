using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    public abstract class Account
    {
        // Fields
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        // Constructor
        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        // Properties
        public Customer Customer 
        {
            get { return this.customer; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer cannot be null!");
                }
                else
                {
                    this.customer = value;
                }
            }
        }

        public decimal Balance 
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative!");
                }
                else
                {
                    this.balance = value;
                }
            }
        }

        public decimal InterestRate 
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest rate cannot be negative!");
                }
                else
                {
                    this.interestRate = value;
                }
            }
        }

        // Methods
        // Calculate interest amount
        public virtual decimal InterestAmount(int numberOfMonths)
        {
            decimal result = numberOfMonths * this.interestRate;

            return result;
        }  
    }
}
