//01.Write three classes: Student, Course and School. Students should have name and unique number 
//(inside the entire School). Name can not be empty and the unique number is between 10000 and 99999. 
//Each course contains a set of students. Students in a course should be less than 30 and can join and leave courses.

//02.Write VSTT tests for these two classes
//-Use 2 class library projects in Visual Studio: School.csproj and TestSchool.csproj

//03.Execute the tests using Visual Studio and check the code coverage. Ensure it is at least 90%.

namespace StudentProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            Student firstStudent = new Student("Plamen Georgiev");
            Student secondStudent = new Student("Ivan Ivanov");
            Student thirdStudent = new Student("Maria Petrova");
            Student fourthStudetn = new Student("Krasimira Hristova");

            Console.WriteLine("---------- PRINT FIRST STUDENT ----------");
            Console.WriteLine(firstStudent);

            Course databasesCourse = new Course(TypeOfCourses.Databases);
            databasesCourse.AddStudentToCourse(firstStudent);
            databasesCourse.AddStudentToCourse(secondStudent);
            databasesCourse.AddStudentToCourse(thirdStudent);

            Console.WriteLine("---------- PRINT ALL STUDENTS IN COURSE ----------");
            Console.WriteLine(databasesCourse);

            Course xmlCourse = new Course(TypeOfCourses.XML);
            xmlCourse.AddStudentToCourse(fourthStudetn);

            Console.WriteLine("---------- PRINT ALL STUDENTS IN COURSE ----------");
            Console.WriteLine(xmlCourse);

            List<Course> coursesInSchool = new List<Course>() { databasesCourse, xmlCourse };

            School telerikAcademy = new School("Telerik Academy", coursesInSchool);

            Console.WriteLine("---------- PRINT ALL COURSES AND STUDENTS IN SCHOOL ----------");
            Console.WriteLine(telerikAcademy);
        }
    }
}
