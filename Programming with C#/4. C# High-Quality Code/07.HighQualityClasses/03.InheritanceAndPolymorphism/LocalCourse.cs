namespace _03.InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LocalCourse : Course
    {
        private string laboratory;

        public LocalCourse(string laboratory, string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            if (laboratory == string.Empty)
            {
                throw new ArgumentException("Laboratory value cannot be empty!");
            }

            if (laboratory == null)
            {
                throw new ArgumentNullException("Laboratory value cannot be null!");
            }

            this.Laboratory = laboratory;
        }

        public LocalCourse(string laboratory, string courseName, string teacherName)
            : this(laboratory, courseName, teacherName, null)
        {
        }

        public LocalCourse(string laboratory)
            : this(laboratory, null, null, null)
        {
        }

        public string Laboratory
        {
            get
            {
                return this.laboratory;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Laboratory value cannot be empty!");
                }

                if (value == null)
                {
                    throw new ArgumentNullException("Laboratory value cannot be null!");
                }

                this.laboratory = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            // Calling method ToString() from class Course
            result.Append(base.ToString());

            if (this.Laboratory != null)
            {
                result.Append("\nLaboratory = ");
                result.Append(this.Laboratory);
            }

            result.Append(" }");

            return result.ToString();
        }
    }
}
