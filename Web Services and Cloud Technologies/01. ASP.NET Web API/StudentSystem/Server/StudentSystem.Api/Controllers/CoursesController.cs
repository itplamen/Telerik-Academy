namespace StudentSystem.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Models.Courses;
    using Services.Data.Contracts;
    using System.Web.Http.Cors;

    public class CoursesController : ApiController
    {
        private readonly ICoursesService courses;

        public CoursesController(ICoursesService coursesService)
        {
            this.courses = coursesService;
        }

        [HttpPost]
        [Authorize]
        public IHttpActionResult Create(CourseResponseModel course)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var addedCourseId = this.courses.Add(course.Name, course.Description, course.StartDate, course.EndDate);

            return this.Ok(addedCourseId);
        }

        [HttpGet]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult All()
        {
            var courses = this.courses.All()
                .Select(CourseResponseModel.FromCourse);

            return this.Ok(courses);
        }

        [EnableCors("*", "*", "*")]
        public IHttpActionResult Get(int id)
        {
            var course = this.courses.All()
                .Select(CourseResponseModel.FromCourse)
                .FirstOrDefault(c => c.Id == id);

            if (course == null)
            {
                return this.NotFound();
            }

            return this.Ok(course);
        }

        [HttpPut]
        [Authorize]
        public IHttpActionResult Update(int id, CourseResponseModel course)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var updatedCourseId = this.courses.Update(id, course.Name, course.Description, course.StartDate, course.EndDate);

            if (updatedCourseId == null)
            {
                return this.NotFound();
            }

            return this.Ok(updatedCourseId);
        }

        [HttpDelete]
        [Authorize]
        public IHttpActionResult Delete(int id)
        {
            var deletedCourseId = this.courses.Delete(id);

            if (deletedCourseId == null)
            {
                return this.NotFound();
            }

            return this.Ok(deletedCourseId);
        }
    }
}