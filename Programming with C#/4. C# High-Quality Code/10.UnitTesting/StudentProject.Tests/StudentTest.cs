namespace StudentProject.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTest
    {
        private Student student;

        [TestInitialize]
        public void TestInitialize()
        {
            this.student = new Student("Plamen Georgiev");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Student.DeleteAllStudentsID();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_NullStudentName()
        {
            new Student(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_EmptyStudentName()
        {
            string studentName = string.Empty;
            new Student(studentName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_WhiteSpaceStudentName()
        {
            new Student("       ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_IDSmallerThanMinimalID()
        {
            this.student.ID = 9999;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_IDBiggerThanMaximalID()
        {
            this.student.ID = 200000;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_ExistID()
        {
            Student secondStudent = new Student("Ivan Ivanov");
            secondStudent.ID = this.student.ID;
        }

        [TestMethod]
        public void GenerateID_EmptyListOfStudentsID()
        {
            int minimalID = 10000;
            Assert.AreEqual(minimalID, this.student.ID, "Minimal ID and student ID are not equals!");
        }

        [TestMethod]
        public void GenerateID_ReturnNewStudentIDIncrementedWithOne()
        {
            Student secondStudent = new Student("Maria Dimitrova");

            int lastStudentID = this.student.ID;
            int expectedID = lastStudentID + 1;
            Assert.AreEqual(expectedID, secondStudent.ID, "Expected ID and student ID are not equals!");
        }

        [TestMethod]
        public void IsIDExist_ReturnExistStudentID()
        {
            bool isStudentIDExist = this.student.IsIDExist(this.student.ID);
            Assert.AreEqual(true, isStudentIDExist);
        }

        [TestMethod]
        public void IsIDExist_ReturnNotExisedtStudentID()
        {
            int studentIDExample = 20000;
            bool isStudentIDExist = this.student.IsIDExist(studentIDExample);
            Assert.AreEqual(false, isStudentIDExist);
        }

        [TestMethod]
        public void ToString_PrintCorrectStudentNameAndID()
        {
            string returned = this.student.ToString();
            string expected = "Name: " + this.student.Name + "\n" + "ID: " + this.student.ID + "\n";
            Assert.AreEqual(expected, returned);
        }
    }
}
