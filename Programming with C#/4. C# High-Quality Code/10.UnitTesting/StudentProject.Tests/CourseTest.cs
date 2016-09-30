namespace StudentProject.Tests
{
    using System;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class CourseTest
    {
        private Course course;
        private Student student;

        [TestInitialize]
        public void TestInitialize()
        {
            this.course = new Course(TypeOfCourses.Databases);
            this.student = new Student("Plamen Georgiev");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Student.DeleteAllStudentsID();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddStudentToCourse_IfStudentsAreMoreThan30InOneCourse()
        {
            int studentNumber = 32;
            for (int i = 0; i < studentNumber; i++)
            {
                this.course.AddStudentToCourse(new Student("Ivan Ivanov"));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddStudentToCourse_NullStudent()
        {
            this.course.AddStudentToCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStudentToCourse_IfStudentExistInTheCourse()
        {
            this.course.AddStudentToCourse(this.student);
            this.course.AddStudentToCourse(this.student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsStudentInThisCourse_NullStudent()
        {
            this.course.IsStudentInThisCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveStudentFromCourse_NullStudent()
        {
            this.course.RemoveStudentFromCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveStudentFromCourse_IfStudentIsNotInThisCourse()
        {
            Student secondStudent = new Student("Maria Dimitrova");
            this.course.RemoveStudentFromCourse(secondStudent);
        }

        [TestMethod]
        public void RemoveStudentFromCourse_RemoveStudent()
        {
            this.course.AddStudentToCourse(this.student);
            this.course.RemoveStudentFromCourse(this.student);

            bool isStudentInCourse = this.course.IsStudentInThisCourse(this.student);
            Assert.AreEqual(false, isStudentInCourse, "Student is not removed from this course!");
        }

        [TestMethod]
        public void ToString_PrintAllStudnetsInGivenCourse()
        {
            this.course.AddStudentToCourse(this.student);
            string expected = this.course.ToString();

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Students in course: " + this.course.CourseName);
            builder.AppendLine(this.student.ToString());

            Assert.AreEqual(expected, builder.ToString());
        }
    }
}
