using StudentSystem.Api.Models.Lectures;
using StudentSystem.Services.Data;
using StudentSystem.Services.Data.Contracts;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentSystem.Api.Controllers
{
    public class LecturesController : ApiController
    {
        private ILecturesService lectures;

        public LecturesController(ILecturesService lecturesService)
        {
            this.lectures = lecturesService;
        }

        [HttpPost]
        [Authorize]
        public IHttpActionResult Create(LectureResponseModel lecture)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var newLectureId = this.lectures.Add(lecture.Name, lecture.CourseId);

            return this.Ok(newLectureId);
        }

        [HttpGet]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult All()
        {
            var lectures = this.lectures.All()
                .Select(LectureResponseModel.FromLecture);

            return this.Ok(lectures);
        }

        [EnableCors("*", "*", "*")]
        public IHttpActionResult Get(int id)
        {
            var lecture = this.lectures.All()
                .Select(LectureResponseModel.FromLecture)
                .FirstOrDefault(l => l.Id == id);

            return this.Ok(lecture);
        }

        [HttpGet]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult ByCourseId(int id)
        {
            var lectures = this.lectures.All()
                .Select(LectureResponseModel.FromLecture)
                .Where(l => l.CourseId == id);

            if (lectures == null)
            {
                return this.NotFound();
            }

            return this.Ok(lectures);
        }

        [HttpPut]
        [Authorize]
        public IHttpActionResult Update(int id, LectureResponseModel lecture)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var updatedLectureId = this.lectures.Update(id, lecture.Name, lecture.CourseId);

            if (updatedLectureId == null)
            {
                return this.NotFound();
            }

            return this.Ok(updatedLectureId);
        }

        [HttpDelete]
        [Authorize]
        public IHttpActionResult Delete(int id)
        {
            var deletedLectureId = this.lectures.Delete(id);

            if (deletedLectureId == null)
            {
                return this.NotFound();
            }

            return this.Ok(deletedLectureId);
        }
    }
}