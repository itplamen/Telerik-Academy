using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class Person : Comment
    {
        // Fields
        private string firstName;
        private string lastName;

        // Constructor
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Properties
        public string FirstName 
        {
            get { return this.firstName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("First name cannot be null!");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName 
        {
            get { return this.lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Last name cannot be null!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
    }
}
