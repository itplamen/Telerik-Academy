namespace _02.SimpleInformationalApp.Data.Models
{
    public class News
    {
        private static int id;

        public News()
        {
            id++;
            this.Id = id;
        }

        public int Id { get; private set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public Category Category { get; set; }
    }
}
