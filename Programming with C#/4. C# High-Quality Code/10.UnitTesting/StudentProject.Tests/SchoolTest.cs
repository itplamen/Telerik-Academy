namespace StudentProject.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTest
    {
        private School school;
        private List<Course> coursesInSchool = new List<Course>() { new Course(TypeOfCourses.CSharp), new Course(TypeOfCourses.XML) };

        [TestInitialize]
        public void TestInitialize()
        {
            this.school = new School("Harvard University", this.coursesInSchool);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_NullSchoolName()
        {
            new School(null, this.coursesInSchool);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_EmptySchoolName()
        {
            string schoolName = string.Empty;
            new School(schoolName, this.coursesInSchool);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_WhiteSpaceSchoolName()
        {
            new School("   ", this.coursesInSchool);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_NullListOfCourses()
        {
            new School("Telerik Academy", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_ListOfCoursesWithNullElements()
        {
            List<Course> list = new List<Course>() { new Course(TypeOfCourses.JavaScript), null };
            new School("Telerik Academy", list);
        }

        [TestMethod]
        public void ToString_PrintAllCoursesAndStudentsInTheSchool()
        {
            string expected = this.school.ToString();

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("School name: " + this.school.SchoolName);

            for (int i = 0; i < this.school.CoursesInSchool.Count; i++)
            {
                builder.AppendLine(this.school.CoursesInSchool[i].ToString());
            }

            Assert.AreEqual(expected, builder.ToString());
        }
    }
}
