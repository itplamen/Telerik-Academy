namespace StudentSystem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        private ICollection<Lecturer> lecturers;
        private ICollection<Student> students;
        private ICollection<Lecture> lectures;
        private ICollection<Homework> homeworks;
        private ICollection<Exam> exams;

        public Course()
        {
            this.lecturers = new HashSet<Lecturer>();
            this.students = new HashSet<Student>();
            this.lectures = new HashSet<Lecture>();
            this.homeworks = new HashSet<Homework>();
            this.exams = new HashSet<Exam>();
        }

        public int Id { get; set; }

        public CourseType Name { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public virtual ICollection<Lecturer> Lecturers
        {
            get { return this.lecturers; }
            set { this.lecturers = value; }
        }

        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        public virtual ICollection<Lecture> Lectures
        {
            get { return this.lectures; }
            set { this.lectures = value; }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }

        public virtual ICollection<Exam> Exams
        {
            get { return this.exams; }
            set { this.exams = value; }
        }
    }
}
