using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class Students : Person
    {
        // Fields
        private int studentClassNumber;

        // Constructor
        public Students(string firstName, string lastName, int studentClassNumber)
            : base(firstName, lastName)
        {
            this.studentClassNumber = studentClassNumber;
        }

        // Properties
        public int StudentClassNumber 
        {
            get { return this.studentClassNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Student class number cannot be negative or zero!");
                }
                else
                {
                    this.studentClassNumber = value;
                }
            }
        }
    }
}
