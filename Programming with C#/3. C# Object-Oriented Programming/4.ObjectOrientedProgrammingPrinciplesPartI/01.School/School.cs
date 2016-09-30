using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class School
    {
        // Fields
        private string schoolName;
        private List<Class> classes;

        //Constructor
        public School(List<Class> classes, string schoolName)
        {
            this.classes = classes;
            this.schoolName = schoolName;
        }

        // Properties
        public string SchoolName 
        {
            get{return this.schoolName;}
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("School name cannot be null!");
                }
                else
                {
                    this.schoolName = value;
                }
            }
        }

        public List<Class> Classes
        {
            get { return this.classes; }
            set { this.classes = value; }
        }

        // Methods
        // Print school name
        public void PrintSchoolName()
        {
            Console.WriteLine("---------- {0} ----------\n", SchoolName);
        }
    }
}
