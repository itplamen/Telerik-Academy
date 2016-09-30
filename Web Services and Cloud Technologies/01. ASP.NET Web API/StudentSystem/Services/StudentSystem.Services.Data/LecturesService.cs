namespace StudentSystem.Services.Data
{
    using System.Linq;

    using StudentSystem.Data;
    using StudentSystem.Model;
    using StudentSystem.Services.Data.Contracts;

    public class LecturesService : ILecturesService
    {
        private readonly IRepository<Lecture> lectures;

        public LecturesService(IRepository<Lecture> lecturesRepo)
        {
            this.lectures = lecturesRepo;
        }

        public IQueryable<Lecture> All()
        {
            return this.lectures.All();
        }

        public int Add(string name, int courseId)
        {
            var newLecture = new Lecture
            {
                Name = name,
                CourseId = courseId
            };

            this.lectures.Add(newLecture);
            this.lectures.SaveChanges();

            return newLecture.Id;
        }

        public int? Update(int id, string name, int courseId)
        {
            var existingLecture = this.All()
                .FirstOrDefault(l => l.Id == id);

            if (existingLecture != null)
            {
                existingLecture.Name = name;
                existingLecture.CourseId = courseId;
                this.lectures.SaveChanges();

                return existingLecture.Id;
            }

            return null;
        }

        public int? Delete(int id)
        {
            var lecture = this.lectures.All()
                .FirstOrDefault(l => l.Id == id);

            if (lecture != null)
            {
                this.lectures.Delete(lecture);
                this.lectures.SaveChanges();

                return lecture.Id;
            }

            return null;
        }
    }
}
