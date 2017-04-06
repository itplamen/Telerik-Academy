namespace Movies.Data.Models
{
    public class Director
    {
        private static int id;

        public Director()
        {
            id++;
            this.Id = id;
        }

        public int Id { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
