namespace StudentProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class School
    {
        private string schoolName;
        private List<Course> coursesInSchool = new List<Course>();

        public School(string schoolName, List<Course> coursesInSchool)
        {
            this.SchoolName = schoolName;
            this.CoursesInSchool = coursesInSchool;
        }

        public string SchoolName 
        {
            get
            {
                return this.schoolName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("School name cannot be null or empty!");
                }

                this.schoolName = value;
            }
        }

        public List<Course> CoursesInSchool 
        {
            get
            {
                return this.coursesInSchool;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("List of courses in school cannot be null!");
                }

                if (value.Count > 0)
                {
                    for (int i = 0; i < value.Count; i++)
                    {
                        if (value[i] == null)
                        {
                            throw new ArgumentNullException("List of courses elements cannot be null!");
                        }
                    }
                }
                
                this.coursesInSchool = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("School name: " + this.SchoolName);

            for (int i = 0; i < this.CoursesInSchool.Count; i++)
            {
                builder.AppendLine(this.CoursesInSchool[i].ToString());
            }

            return builder.ToString();
        }
    }
}
