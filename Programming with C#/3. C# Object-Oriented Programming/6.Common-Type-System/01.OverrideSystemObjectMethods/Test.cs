//1. Define a class Student, which contains data about a student – first, middle and last name, SSN, 
//permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, 
//universities and faculties. Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() 
//and operators == and !=.

//2. Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object 
//of type Student.

//3. Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
//and by social security number (as second criteria, in increasing order).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OverrideSystemObjectMethods
{
    class Test
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student("Plamen", "Svetlozarov", "Georgiev", 6612331, "Ruse", "08812345", "itplamen@gmail.com", 4, Universities.RU, Faculties.EEA, Specialties.KST);
            Student secondStudent = new Student("Pesho", "Petrov", "Ivanov", 113123, "Sofia", "0881111", "pesho@abv.bg", 1, Universities.SU, Faculties.Law, Specialties.Law);

            Console.WriteLine("First student equal to second student? {0}", Student.Equals(firstStudent, secondStudent)); // False
            Console.WriteLine("First student == second student? {0}", firstStudent == secondStudent); // False
            Console.WriteLine("Firs student != second student? {0}", firstStudent != secondStudent); // True
            Console.WriteLine();

            Student thirdStudent = new Student("Plamen", "Svetlozarov", "Georgiev", 6612331, "Ruse", "08812345", "itplamen@gmail.com", 4, Universities.RU, Faculties.EEA, Specialties.KST);

            Console.WriteLine("First student equal to third student? {0}", Student.Equals(firstStudent, thirdStudent)); // True
            Console.WriteLine("First student == third student? {0}", firstStudent == thirdStudent); // True;
            Console.WriteLine("First student != third student? {0}", firstStudent != thirdStudent); // False
            Console.WriteLine();

            Student cloned = firstStudent.Clone();
            Console.WriteLine("Cloned: ");
            Console.WriteLine(cloned);

            int compareStudents = firstStudent.CompareTo(secondStudent);
            Console.WriteLine("Compare result: " + compareStudents);
        }
    }
}
