namespace _01.Academy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : IComparable<Student>
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName 
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid first name!");
                }

                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid last name!");
                }

                this.lastName = value;
            }
        }

        public int CompareTo(Student other)
        {
            int firstNamesResult = this.FirstName.CompareTo(other.FirstName);

            if (firstNamesResult != 0)
            {
                return firstNamesResult;
            }
            else
            {
                return this.LastName.CompareTo(other.LastName);
            }
        }
    }
}
