namespace StudentSystem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Exam
    {
        private ICollection<Student> students;

        public Exam()
        {
            this.students = new HashSet<Student>();
        }

        public int Id { get; set; }

        public DateTime? Date { get; set; }

        public string Address { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        [NotMapped]
        public bool IsDateValid
        {
            get
            {
                if (this.Date <= this.Course.EndDate)
                {
                    return false;
                }

                return true;
            }
        }
    }
}
