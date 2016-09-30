using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OverrideSystemObjectMethods
{
    public class Student : ICloneable, IComparable<Student>
    {
        /* PROPERTIES */
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public byte Course { get; set; }
        public Universities University { get; set; }
        public Faculties Faculty { get; set; }
        public Specialties Specialty { get; set; }

        /* CONSTRUCTOR */
        public Student(string firstName, string middleName, string lastName, int ssn, string address, string phoneNumber, string email,
            byte course, Universities university, Faculties faculty, Specialties specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }


        /* METHODS */
        
        // Override Equals() method
        public override bool Equals(object obj)
        {   
            Student student = obj as Student;

            if (student == null)
            {
                return false;    
            }

            if (student.FirstName == this.FirstName && student.MiddleName == this.MiddleName && student.LastName == this.LastName &&
                student.SSN == this.SSN && student.Address == this.Address && student.PhoneNumber == this.PhoneNumber && student.Email == this.Email &&
                student.Course == this.Course && student.Specialty == this.Specialty && student.University == this.University && student.Faculty == this.Faculty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Override GetHashCode() method
        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode();
        }

        // Override ToString() method
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("First name: " + this.FirstName);
            builder.AppendLine("Middle name: " + this.MiddleName);
            builder.AppendLine("Last name: " + this.LastName);
            builder.AppendLine("SSN: " + this.SSN);
            builder.AppendLine("Address: " + this.Address);
            builder.AppendLine("Phone number: " + this.PhoneNumber);
            builder.AppendLine("Email: " + this.Email);
            builder.AppendLine("Course: " + this.Course);
            builder.AppendLine("University: " + this.University);
            builder.AppendLine("Faculty: " + this.Faculty);
            builder.AppendLine("Specialty: " + this.Specialty);

            return builder.ToString();
        }

        // Overload operator ==
        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        // Overload operator !=
        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(Student.Equals(firstStudent, secondStudent));
        }

        // Implement Clone() method from IClonable
        object ICloneable.Clone()
        {
            return this.Clone();  
        }

        // Deep cloning
        public Student Clone()
        {
            Student result = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.PhoneNumber, this.Email, this.Course, this.University, this.Faculty, this.Specialty);

            return result;
        }

        // Implement CompareTo() method from IComparable
        public int CompareTo(Student currentStudent)
        {
            int firstNameCompare = this.FirstName.CompareTo(currentStudent.FirstName);

            if (firstNameCompare != 0)
            {
                return firstNameCompare;
            }
            else
            {
                int middleNameCompare = this.MiddleName.CompareTo(currentStudent.MiddleName);

                if (middleNameCompare != 0)
                {
                    return middleNameCompare;
                }
                else
                {
                    int lastNameCompare = this.LastName.CompareTo(currentStudent.LastName);

                    if (lastNameCompare != 0 )
                    {
                        return lastNameCompare;
                    }
                    else
                    {
                        int SSNCompare = this.SSN.CompareTo(currentStudent.SSN);

                        if (SSNCompare != 0) // If names are equals, compare students by SSN
                        {
                            return SSNCompare;
                        }
                        else // Both students are equals
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
