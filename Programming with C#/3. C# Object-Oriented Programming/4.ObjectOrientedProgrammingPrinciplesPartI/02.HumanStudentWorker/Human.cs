using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HumanStudentWorker
{
    public abstract class Human
    {
        // Fields
        private string firstName;
        private string lastName;

        // Constructor
        public Human(string firstName, string lastName)
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
