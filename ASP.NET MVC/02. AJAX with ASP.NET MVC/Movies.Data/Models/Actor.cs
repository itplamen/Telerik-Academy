namespace Movies.Data.Models
{
    public class Actor
    {
        private static int id;

        public Actor()
        {
            id++;
            this.Id = id;
        }

        public int Id { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }
    }
}
