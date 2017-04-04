namespace _02.SimpleInformationalApp.Web.Models.News
{
    using Data.Models;

    public class NewsByIdViewModel
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public Category Category { get; set; }
    }
}