using StudentSystem.Model;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace StudentSystem.Data
{
    public interface IStudentSystemDbContext
    {
        IDbSet<Course> Courses { get; set; }

        IDbSet<Exam> Exams { get; set; }

        IDbSet<Homework> Homeworks { get; set; }

        IDbSet<Lecture> Lectures { get; set; }

        IDbSet<Material> Materials { get; set; }

        IDbSet<Lecturer> Lecturers { get; set; }

        IDbSet<Student> Students { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}
