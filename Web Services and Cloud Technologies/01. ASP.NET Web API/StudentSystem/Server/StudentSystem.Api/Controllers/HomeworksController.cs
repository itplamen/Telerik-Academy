using StudentSystem.Api.Models.Homeworks;
using StudentSystem.Services.Data;
using StudentSystem.Services.Data.Contracts;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentSystem.Api.Controllers
{
    public class HomeworksController : ApiController
    {
        private readonly IHomeworksService homeworks;

        public HomeworksController(IHomeworksService homeworkService)
        {
            this.homeworks = homeworkService;
        }

        [HttpPost]
        [Authorize]
        public IHttpActionResult Create(HomeworkResponseModel homework)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var newHomeworkId = this.homeworks.Add(homework.Description, homework.TimeSent, homework.StudentId, homework.CourseId);

            return this.Ok(newHomeworkId);
        }

        [HttpGet]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult All()
        {
            var homeworks = this.homeworks.All()
                .Select(HomeworkResponseModel.FromHomework);

            return this.Ok(homeworks);
        }

        [EnableCors("*", "*", "*")]
        public IHttpActionResult Get(int id)
        {
            var homework = this.homeworks.All()
                .Select(HomeworkResponseModel.FromHomework)
                .FirstOrDefault(h => h.Id == id);

            if (homework == null)
            {
                return this.NotFound();
            }

            return this.Ok(homework);
        }

        [HttpGet]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult ByStudentId(int id)
        {
            var homeworks = this.homeworks.All()
                .Select(HomeworkResponseModel.FromHomework)
                .Where(h => h.StudentId == id);

            if (homeworks == null)
            {
                return this.NotFound();
            }

            return this.Ok(homeworks);
        }

        [HttpGet]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult ByCourseId(int id)
        {
            var homework = this.homeworks.All()
                .Select(HomeworkResponseModel.FromHomework)
                .Where(h => h.CourseId == id);

            if (homework == null)
            {
                return this.NotFound();
            }

            return this.Ok(homework);
        }

        [HttpPut]
        [Authorize]
        public IHttpActionResult Update(int id, HomeworkResponseModel homework)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var updatedHomeworkId = this.homeworks.Update(id, homework.Description, homework.TimeSent, homework.StudentId, homework.CourseId);

            if (updatedHomeworkId == null)
            {
                return null;
            }

            return this.Ok(updatedHomeworkId);
        }

        [HttpDelete]
        [Authorize]
        public IHttpActionResult Delete(int id)
        {
            var deletedHomeworkId = this.homeworks.Delete(id);

            if (deletedHomeworkId == null)
            {
                return this.NotFound();
            }

            return this.Ok(deletedHomeworkId);
        }
    }
}