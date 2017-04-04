namespace _02.SimpleInformationalApp.Data
{
    using System.Collections.Generic;

    using Models;
    
    public sealed class Database
    {
        private static Database instance;

        private Database()
        {
            this.Users = new List<User>();
            this.Users.Add(new User()
            {
                FirsName = "Plamen",
                LastName = "Georgiev",
                UserRole = UserRoles.Administrator
            });
            this.Users.Add(new User()
            {
                FirsName = "Ivan",
                LastName = "Ivanov",
                UserRole = UserRoles.User
            });
            this.Users.Add(new User()
            {
                FirsName = "Krasimir",
                LastName = "Gerov",
                UserRole = UserRoles.User
            });
            this.Users.Add(new User()
            {
                FirsName = "Ivelina",
                LastName = "Titova",
                UserRole = UserRoles.User
            });

            this.Categories = new List<Category>();
            this.Categories.Add(new Category() { Name = "Art" });
            this.Categories.Add(new Category() { Name = "Sport" });
            this.Categories.Add(new Category() { Name = "Music" });

            this.News = new List<News>();
            this.News.Add(new News()
            {
                Title = "Art Title 1",
                Content = "Art Content 1",
                Category = this.Categories[0]   
            });
            this.News.Add(new News()
            {
                Title = "Art Title 2",
                Content = "Art Content 2",
                Category = this.Categories[0]
            });
            this.News.Add(new News()
            {
                Title = "Sport Title 1",
                Content = "Sport Content 1",
                Category = this.Categories[1]
            });
            this.News.Add(new News()
            {
                Title = "Sport Title 2",
                Content = "Sport Content 2",
                Category = this.Categories[1]
            });
            this.News.Add(new News()
            {
                Title = "Music Title 1",
                Content = "Music Content 1",
                Category = this.Categories[2]
            });
            this.News.Add(new News()
            {
                Title = "Music Title 2",
                Content = "Music Content 2",
                Category = this.Categories[2]
            });
        }

        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }

                return instance;
            }
        }

        public IList<User> Users { get; set; }

        public IList<Category> Categories { get; set; }

        public IList<News> News { get; set; }
    }
}
