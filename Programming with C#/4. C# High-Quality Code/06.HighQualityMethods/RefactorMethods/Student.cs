namespace RefactorMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;

        public Student(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }

        public string FirstName 
        {
            get 
            { 
                return this.firstName; 
            }

            set
            {
                if ((this.firstName == string.Empty) || (this.firstName == null))
                {
                    throw new ArgumentException("Student first name cannot be empty or null!");
                }
                else
                {
                    this.firstName = value;
                }
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
                if ((this.lastName == string.Empty) || (this.lastName == null))
                {
                    throw new ArgumentException("Student last name cannot be empty or null!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }

            set
            {
                if (this.dateOfBirth == null)
                {
                    throw new ArgumentNullException("Student date of birth cannot be null!");
                }
                else
                {
                    this.dateOfBirth = value;
                }
            }
        }

        public bool IsOlderThan(Student student)
        {
            if (this.DateOfBirth > student.DateOfBirth)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
