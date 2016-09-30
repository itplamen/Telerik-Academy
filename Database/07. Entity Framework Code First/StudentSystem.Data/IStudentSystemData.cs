namespace StudentSystem.Data
{
    using StudentSystem.Data.Repositories;
    using StudentSystem.Model;

    public interface IStudentSystemData
    {
        IGenericRepository<Student> Students { get; }

        IGenericRepository<Course> Courses { get; }

        IGenericRepository<Lecture> Lectures { get; }

        IGenericRepository<Lecturer> Lecturers { get; }

        IGenericRepository<Material> Materials { get; }

        IGenericRepository<Homework> Homeworks { get; }

        IGenericRepository<Exam> Exams { get; }
    }
}
