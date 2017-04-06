namespace Movies.Web.Models.Actors
{
    using System;
    using System.Linq.Expressions;

    using Data.Models;

    public class AllActorsViewModel
    {
        public static Expression<Func<Actor, AllActorsViewModel>> FromActor
        {
            get
            {
                return actor => new AllActorsViewModel
                {
                    Id = actor.Id,
                    FullName = actor.FirstName + " " + actor.LastName,
                    Age = actor.Age,
                    Gender = actor.Gender.ToString()
                };
            }
        }

        public int Id { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }
    }
}