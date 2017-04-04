namespace _02.SimpleInformationalApp.Data.Models
{
    public class Category
    {
        private static int id;

        public Category()
        {
            id++;
            this.Id = id;
        }

        public int Id { get; private set; }

        public string Name { get; set; }
    }
}
