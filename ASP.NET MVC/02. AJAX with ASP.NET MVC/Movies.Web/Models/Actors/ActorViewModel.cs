namespace Movies.Web.Models.Actors
{
    using System;
    using System.Linq.Expressions;

    using Data.Models;
    
    public class ActorViewModel
    {
        public static Expression<Func<Actor, ActorViewModel>> FromActor
        {
            get
            {
                return actor => new ActorViewModel
                {
                    Id = actor.Id,
                    FirstName = actor.FirstName,
                    LastName = actor.LastName,
                    Age = actor.Age,
                    Gender = actor.Gender
                };
            }
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }
    }
}