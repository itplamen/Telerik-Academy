namespace StudentSystem.Data
{
    using System;
    using System.Collections.Generic;

    using StudentSystem.Data.Repositories;
    using StudentSystem.Model;

    public class StudentSystemData : IStudentSystemData
    {
        private IStudentSystemContext contex;
        private IDictionary<Type, object> repositories;

        public StudentSystemData()
            : this(new StudentSystemContext())
        {
            this.repositories = new Dictionary<Type, object>();
        }

        public StudentSystemData(IStudentSystemContext context)
        {
            this.contex = context;
        }

        public IGenericRepository<Student> Students
        {
            get { return new GenericRepository<Student>(this.contex); }
        }

        public IGenericRepository<Course> Courses
        {
            get { return new GenericRepository<Course>(this.contex); }
        }

        public IGenericRepository<Lecture> Lectures
        {
            get { return new GenericRepository<Lecture>(this.contex); }
        }

        public IGenericRepository<Lecturer> Lecturers
        {
            get { return new GenericRepository<Lecturer>(this.contex); }
        }

        public IGenericRepository<Material> Materials
        {
            get { return new GenericRepository<Material>(this.contex); }
        }

        public IGenericRepository<Homework> Homeworks
        {
            get { return new GenericRepository<Homework>(this.contex); }
        }

        public IGenericRepository<Exam> Exams
        {
            get { return new GenericRepository<Exam>(this.contex); }
        }

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var typeOfRepository = typeof(GenericRepository<T>);
                var newRepository = Activator.CreateInstance(typeOfRepository, this.contex);
                this.repositories.Add(typeOfModel, newRepository);
            }

            return (IGenericRepository<T>)this.repositories[typeOfModel];
        }
    }
}
