namespace Movies.Data.Models
{
    public class Movie
    {
        private static int id;

        public Movie()
        {
            id++;
            this.Id = id;
        }

        public int Id { get; private set; }

        public string Title { get; set; }

        public Director Director { get; set; }

        public int Year { get; set; }

        public Actor LeadingMaleRole { get; set; }

        public Actor LeadingFemaleRole { get; set; }

        public Studio Studio { get; set; }
    }
}
