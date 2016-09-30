namespace StudentSystem.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Lecturer
    {
        private ICollection<Course> courses;

        public Lecturer()
        {
            this.courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string FirsName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string LastName { get; set; }

        public JobPosition JobPosition { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }
    }
}
