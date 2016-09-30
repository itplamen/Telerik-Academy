using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HumanStudentWorker
{
    public class Student : Human
    {
        // Fields
        private int grade;

        // Constructor
        public Student(string firstName, string lastName, int grade)
            : base (firstName, lastName)
        {
            this.grade = grade;
        }

        // Properties
        public int Grade 
        {
            get { return this.grade; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Grade cannot be different by the range 1-12!");
                }
                else
                {
                    this.grade = value;
                }
            }
        }
    }
}
