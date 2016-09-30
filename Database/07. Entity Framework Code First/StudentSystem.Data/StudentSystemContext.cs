namespace StudentSystem.Data
{
    using System.Data.Entity;

    using StudentSystem.Data.Migrations;
    using StudentSystem.Model;
    
    public class StudentSystemContext : DbContext, IStudentSystemContext
    {
        public StudentSystemContext()
            : base("StudentSystemDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>());
        }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Exam> Exams { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }

        public IDbSet<Lecture> Lectures { get; set; }

        public IDbSet<Material> Materials { get; set; }

        public IDbSet<Lecturer> Lecturers { get; set; }

        public IDbSet<Student> Students { get; set; }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
