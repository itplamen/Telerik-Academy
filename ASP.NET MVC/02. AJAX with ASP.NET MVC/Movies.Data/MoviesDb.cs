namespace Movies.Data
{
    using System.Collections.Generic;

    using Models;

    public sealed class MoviesDb
    {
        private static MoviesDb instance;

        private MoviesDb()
        {
            Actors = new List<Actor>();
            Actors.Add(new Actor()
            {
                FirstName = "Plamen",
                LastName = "Georgiev",
                Age = 25,
                Gender = Gender.Male
            });
            Actors.Add(new Actor()
            {
                FirstName = "Iva",
                LastName = "Ivova",
                Age = 22,
                Gender = Gender.Female
            });

            Directors = new List<Director>();
            Directors.Add(new Director()
            {
                FirstName = "Krasimir",
                LastName = "Ivanov"
            });

            Studios = new List<Studio>();
            Studios.Add(new Studio()
            {
                Name = "Sofia Studio",
                Address = "Address Sofia Studio, str. Hristo Botev"
            });

            Movies = new List<Movie>();
            Movies.Add(new Movie()
            {
                Title = "Some Movie Title",
                Year = 2017,
                Director = Directors[0],
                LeadingMaleRole = Actors[0],
                LeadingFemaleRole = Actors[1],
                Studio = Studios[0]
            });
        }

        public static MoviesDb Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MoviesDb();
                }

                return instance;
            }
        }

        public List<Actor> Actors { get; set; }

        public List<Director> Directors { get; set; }

        public List<Movie> Movies { get; set; }

        public List<Studio> Studios { get; set; }
    }
}
