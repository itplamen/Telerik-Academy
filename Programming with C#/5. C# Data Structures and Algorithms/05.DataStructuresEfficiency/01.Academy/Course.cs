namespace _01.Academy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Course : IComparable<Course>
    {
        private string courseName;

        public Course(string courseName)
        {
            this.CourseName = courseName;
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid course name!");
                }

                this.courseName = value;
            }
        }

        public int CompareTo(Course other)
        {
            return this.CourseName.CompareTo(other.CourseName);
        }
    }
}
