using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class Class : Comment
    {
        // Fields
        private List<Students> students;
        private List<Teachers> teachers;
        private string classID;

        // Constructor
        public Class(List<Students> students, List<Teachers> teachers, string classID)
        {
            this.students = students;
            this.teachers = teachers;
            this.classID = classID;
        }

        // Properties
        public List<Students> Students
        {
            get { return this.students; }
            set { this.students = value; } 
        }

        public List<Teachers> Teachers
        {
            get { return this.teachers; }
            set { this.teachers = value; } 
        }

        public string ClassID 
        {
            get { return this.classID; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Class ID cannot be null!");
                }
                else
                {
                    this.classID = value;
                }
            }
        }

        // Methods
        // Ovveride ToString()
        public override string ToString()
        {
            // Print information about students
            Console.WriteLine("Students .....");
            foreach (var element in Students)
            {
                Console.WriteLine("Full name: {0}, Class: {1}, ClassID: {2}", element.FirstName + " " + element.LastName, element.StudentClassNumber, ClassID);
            }
            Console.WriteLine();

            // Print information about teachers
            Console.WriteLine("Teachers .....");
            foreach (var element in Teachers)
            {
                Console.WriteLine("Full name: {0} \n\nDisciplines: ", element.FirstName + " " + element.LastName);

                foreach (var item in element.Discipline)
                {
                    Console.WriteLine("Discipline name: " + item.DisciplineName);
                    Console.WriteLine("Number of lectures: " + item.NumberOfLectures);
                    Console.WriteLine("Number of exercises: " + item.NumberOfExercises);
                    Console.WriteLine();
                }
            }

            return base.ToString();
        }
    }
}
