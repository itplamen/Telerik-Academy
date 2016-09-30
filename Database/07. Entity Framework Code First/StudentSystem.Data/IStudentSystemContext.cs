namespace StudentSystem.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using StudentSystem.Model;
        
    public interface IStudentSystemContext
    {
        IDbSet<Course> Courses { get; set; }

        IDbSet<Exam> Exams { get; set; }

        IDbSet<Homework> Homeworks { get; set; }

        IDbSet<Lecture> Lectures { get; set; }

        IDbSet<Material> Materials { get; set; }

        IDbSet<Lecturer> Lecturers { get; set; }

        IDbSet<Student> Students { get; set; }

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();
    }
}
