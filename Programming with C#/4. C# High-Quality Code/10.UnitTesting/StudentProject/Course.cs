namespace StudentProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Course
    {
        private TypeOfCourses courseName;
        private List<Student> studentsInCourse = new List<Student>();

        public Course(TypeOfCourses courseName)
        {
            this.CourseName = courseName;
        }

        public TypeOfCourses CourseName 
        {
            get
            {
                return this.courseName;
            }

            private set
            {
                this.courseName = value;
            }
        }

        public void AddStudentToCourse(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Cannot add student into course. Student cannot be null!");
            }

            if (this.studentsInCourse.Count > 30)
            {
                throw new ArgumentOutOfRangeException("Students in the course cannot be bigger than 30!");
            }

            if (this.IsStudentInThisCourse(student) == true)
            {
                throw new ArgumentException("Student is already in this course!");
            }

            this.studentsInCourse.Add(student);
        }

        public bool IsStudentInThisCourse(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Cannot check if student is in this course. Student cannot be null!");
            }

            for (int i = 0; i < this.studentsInCourse.Count; i++)
            {
                if (student == this.studentsInCourse[i])
                {
                    return true;
                }
            }

            return false;
        }

        public void RemoveStudentFromCourse(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Cannot remove student from the course. Student cannot be null!");
            }

            if (this.IsStudentInThisCourse(student) == false)
            {
                throw new ArgumentException("Student is NOT in this course!");
            }

            this.studentsInCourse.Remove(student);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Students in course: " + this.CourseName);

            for (int i = 0; i < this.studentsInCourse.Count; i++)
            {
                builder.AppendLine(this.studentsInCourse[i].ToString());
            }

            return builder.ToString();
        }
    }
}
