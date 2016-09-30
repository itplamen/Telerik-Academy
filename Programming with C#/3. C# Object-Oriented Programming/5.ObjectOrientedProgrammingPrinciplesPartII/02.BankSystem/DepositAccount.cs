using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    public class DepositAccount : Account, IDepositable, IWithDrawable
    {
        // Constructor
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        // Methods
        // Deposit money
        public void Deposit(decimal depositMoney)
        {
            if (depositMoney <= 0)
            {
                throw new ArgumentException("Deposit money cannot be negative or zero!");
            }
            else
            {
                this.Balance += depositMoney;
            }
        }

        // Withdraw money
        public void WithDraw(decimal withDrawMoney)
        {
            if (withDrawMoney <= 0)
            {
                throw new ArgumentException("Withdraw money cannot be negative or zero!");
            }
            else if (this.Balance <= withDrawMoney)
            {
                throw new ArgumentException("Cannot't withdraw more money than have in balance!");
            }
            else
            {
                this.Balance -= withDrawMoney;
            }
        }

        // Override InterestAmount method from Account.cs
        public override decimal InterestAmount(int numberOfMonths)
        {
            if (base.Balance >= 0 && base.Balance <= 1000)
            {
                return 0;
            }
            else if (base.Balance > 1000)
            {
                return numberOfMonths * base.InterestRate;
            }
            else
            {
                throw new ArgumentException("Balance cannot be negative!");
            }
        }
    }
}
