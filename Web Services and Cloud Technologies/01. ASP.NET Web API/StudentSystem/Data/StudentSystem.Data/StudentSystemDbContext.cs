namespace StudentSystem.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using StudentSystem.Model;
    using System.Data.Entity;
    public class StudentSystemDbContext : IdentityDbContext<User>, IStudentSystemDbContext
    {
        public StudentSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Course> Courses { get; set; }

        public virtual IDbSet<Exam> Exams { get; set; }

        public virtual IDbSet<Homework> Homeworks { get; set; }

        public virtual IDbSet<Lecture> Lectures { get; set; }

        public virtual IDbSet<Material> Materials { get; set; }

        public virtual IDbSet<Lecturer> Lecturers { get; set; }

        public virtual IDbSet<Student> Students { get; set; }

        public static StudentSystemDbContext Create()
        {
            return new StudentSystemDbContext();
        }
    }
}
