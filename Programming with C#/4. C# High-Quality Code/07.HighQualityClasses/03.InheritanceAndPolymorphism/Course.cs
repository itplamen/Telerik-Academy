namespace _03.InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Course
    {
        private string courseName;
        private string teacherName;
        private IList<string> students;

        public Course(string courseName, string teacherName, IList<string> students)
        {
            if (courseName == string.Empty)
            {
                throw new ArgumentException("Course name cannot be empty!");
            }

            if (teacherName == string.Empty)
            {
                throw new ArgumentException("Teacher name cannot be empty!");
            }

            this.courseName = courseName;
            this.teacherName = teacherName;
            this.students = students;
        }

        public Course(string courseName, string teacherName)
            : this(courseName, teacherName, null)
        {
        }

        public string CourseName 
        {
            get
            {
                return this.courseName;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Course name cannot be empty!");
                }

                if (value == null)
                {
                    throw new ArgumentNullException("Course name cannot be null!");
                }

                this.courseName = value;
            }
        }

        public string TeacherName 
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Teacher name cannot be empty!");
                }

                if (value == null)
                {
                    throw new ArgumentNullException("Teacher name cannot be null!");
                }

                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Students cannot be null!");
                }

                this.students = value;
            }
        }

        public string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Course name: " + this.CourseName);

            if (this.TeacherName != null)
            {
                result.Append("\nTeacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("\nStudents = ");
            result.Append(this.GetStudentsAsString());
            
            return result.ToString();
        }
    }
}
