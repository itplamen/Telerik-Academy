namespace _02.SimpleInformationalApp.Data.Models
{
    public class User
    {
        private static int id;

        public User()
        {
            id++;
            this.Id = id;
        }

        public int Id { get; private set; }

        public string FirsName { get; set; }

        public string LastName { get; set; }

        public UserRoles UserRole { get; set; }
    }
}
