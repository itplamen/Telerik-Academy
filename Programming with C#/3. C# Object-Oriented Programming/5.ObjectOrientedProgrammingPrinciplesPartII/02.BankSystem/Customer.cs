using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    public class Customer
    {
        // Fields
        private CustomerType customerType;
        private string fullName;
        private string address;
        private string phoneNumber;

        // Constructor
        public Customer(CustomerType customerType, string fullName, string address, string phoneNumber)
        {
            this.customerType = customerType;
            this.fullName = fullName;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        // Properties
        public CustomerType CustomerType
        {
            get { return this.customerType; }
            set
            {
                this.customerType = value;
            }
        }

        public string FullName
        {
            get { return this.fullName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer full name cannot be null!");
                }
                else
                {
                    this.fullName = value;
                }
            }
        }

        public string Address 
        {
            get { return this.address; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer address cannot be null!");
                }
                else
                {
                    this.address = value;
                }
            }
        }

        public string PhoneNumber 
        {
            get { return this.phoneNumber; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer phone number cannot be null!");
                }
                else
                {
                    this.phoneNumber = value;
                }
            }
        }
    }
}
