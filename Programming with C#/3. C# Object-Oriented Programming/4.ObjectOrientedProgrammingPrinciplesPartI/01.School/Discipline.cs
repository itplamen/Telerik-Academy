using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class Discipline : Comment
    {
        // Fields
        private string disciplineName;
        private int numberOfLectures;
        private int numberOfExercises;

        // Constructor
        public Discipline(string disciplineName, int numberOfLectures, int numberOfExercises)
        {
            this.disciplineName = disciplineName;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
        }

        // Properties
        public string DisciplineName 
        {
            get { return this.disciplineName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Discipline name cannot be null!");
                }
                else
                {
                    this.disciplineName = value;
                }
            }
        }

        public int NumberOfLectures 
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Number of lectures cannot be negative or zero!");
                }
                else
                {
                    this.numberOfLectures = value;
                }
            }
        }

        public int NumberOfExercises 
        {
            get { return this.numberOfExercises; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Number of exercises cannot be null!");
                }
                else
                {
                    this.numberOfExercises = value;
                }
            }
        }
    }
}
