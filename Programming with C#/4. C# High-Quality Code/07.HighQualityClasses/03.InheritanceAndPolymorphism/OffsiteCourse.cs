namespace _03.InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string town, string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            if (town == string.Empty)
            {
                throw new ArgumentException("Town cannot be empty!");
            }

            if (town == null)
            {
                throw new ArgumentNullException("Town cannot be null!");
            }

            this.Town = town;
        }

        public OffsiteCourse(string town, string courseName, string teacherName)
            : this(town, courseName, teacherName, null)
        {
        }

        public OffsiteCourse(string town)
            : this(town, null, null)
        {
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Town cannot be empty!");
                }

                if (value == null)
                {
                    throw new ArgumentNullException("Town cannot be null!");
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            // Calling method ToString() from class Course
            result.Append(base.ToString()); 

            if (this.Town != null)
            {
                result.Append("\nTown = ");
                result.Append(this.Town);
            }

            result.Append(" }");

            return result.ToString();
        }
    }
}
