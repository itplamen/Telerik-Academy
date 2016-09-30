//01.We are given a school. In the school there are classes of students. Each class has a set of teachers. 
//Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique 
//text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. 
//Both teachers and students are people. Students, classes, teachers and disciplines could have optional 
//comments (free text block).
    
//Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate 
//their fields, define the class hierarchy and create a class diagram with Visual Studio.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class Test
    {
        static void Main(string[] args)
        {
            Students plamenStudent = new Students("Plamen", "Georgiev", 12);
            plamenStudent.AddComment("Plamen is a good student");

            Students peshoStudent = new Students("Pesho", "Peshov", 2);
            peshoStudent.AddComment("Pesho is a bad student");

            Students ivaStudent = new Students("Iva", "Ivanova", 7);
            ivaStudent.AddComment("Iva is poor student");

            Discipline mathematics = new Discipline("Mathematics", 2, 2);
            mathematics.AddComment("I like Mathematics");

            Discipline physics = new Discipline("Physics", 8, 4);
            Discipline chemistry = new Discipline("Chemistry", 3, 2);
            Discipline economy = new Discipline("Economy", 1, 1);

            Teachers mariaTeacher = new Teachers("Maria", "Dimitrova", new List<Discipline>() { mathematics, physics, chemistry });
            mariaTeacher.AddComment("Maria Dimitrova is a great teacher");

            Teachers goshoTeacher = new Teachers("Gosho", "Goshov", new List<Discipline>() { economy });
            Class firstClass = new Class(new List<Students>() { plamenStudent, peshoStudent}, new List<Teachers>() { mariaTeacher }, "A");
            Class secondClass = new Class(new List<Students>() { ivaStudent }, new List<Teachers>() { goshoTeacher }, "B");

            School school = new School(new List<Class>() { firstClass, secondClass }, "SOU \"Vasil Levski\"");
            school.PrintSchoolName();
            firstClass.ToString();
            secondClass.ToString();

            // Show comments
            plamenStudent.PrintComment();
            peshoStudent.PrintComment();
            ivaStudent.PrintComment();
            mathematics.PrintComment();
            mariaTeacher.PrintComment();
        }
    }
}
