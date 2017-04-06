namespace Movies.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;

    using Data;
    using Data.Models;
    using Models.Actors;

    public class ActorsController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var db = MoviesDb.Instance;

            var allActors = db.Actors
                .AsQueryable()
                .Select(AllActorsViewModel.FromActor)
                .ToList();

            return this.View(allActors);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(ActorViewModel actor)
        {
            var db = MoviesDb.Instance;

            var actorToAdd = new Actor()
            {
                FirstName = actor.FirstName,
                LastName = actor.LastName,
                Age = actor.Age,
                Gender = actor.Gender
            };

            db.Actors.Add(actorToAdd);

            var addedActor = db.Actors
                .AsQueryable()
                .Select(ActorViewModel.FromActor)
                .LastOrDefault();

            return this.PartialView("_CreateActorPartial", addedActor);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var db = MoviesDb.Instance;

            var actorToUpdate = db.Actors
                .AsQueryable()
                .Select(ActorViewModel.FromActor)
                .FirstOrDefault(a => a.Id == id);

            if (actorToUpdate == null)
            {
                return this.RedirectToAction("Index");
            }

            return this.View(actorToUpdate);
        }

        [HttpPost]
        public ActionResult Update(int id, ActorViewModel actor)
        {
            var db = MoviesDb.Instance;

            var actorToUpdate = db.Actors
                .FirstOrDefault(a => a.Id == id);

            if (actorToUpdate == null)
            {
                return this.View();
            }

            actorToUpdate.FirstName = actor.FirstName;
            actorToUpdate.LastName = actor.LastName;
            actorToUpdate.Age = actor.Age;
            actorToUpdate.Gender = actor.Gender;

            return this.RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var db = MoviesDb.Instance;

            var actorToDelete = db.Actors
                .AsQueryable()
                .Select(ActorViewModel.FromActor)
                .FirstOrDefault(a => a.Id == id);

            if (actorToDelete == null)
            {
                return this.RedirectToAction("Index");
            }

            return this.View(actorToDelete);
        }

        [HttpDelete]
        public ActionResult DeleteActor(int id)
        {
            var db = MoviesDb.Instance;

            var actorToDelete = db.Actors
                .FirstOrDefault(a => a.Id == id);

            if (actorToDelete != null)
            {
                db.Actors.Remove(actorToDelete);
            }

            return this.RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ServerTime()
        {
            string dateTime = DateTime.Now.ToString();
            return this.Content(dateTime);
        }
    }
}