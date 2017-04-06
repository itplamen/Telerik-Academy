namespace Movies.Data.Models
{
    public class Studio
    {
        private static int id;

        public Studio()
        {
            id++;
            this.Id = id;
        }

        public int Id { get; private set; }

        public string Name { get; set; }

        public string Address { get; set; }
    }
}
