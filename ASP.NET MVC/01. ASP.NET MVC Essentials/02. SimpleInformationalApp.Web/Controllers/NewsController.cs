namespace _02.SimpleInformationalApp.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Data;
    using Models.News;

    public class NewsController : Controller
    {
        private Database database = Database.Instance;

        [HttpGet]
        public ActionResult Index()
        {
            var result = new AllNewsViewModel();
            result.News = this.database.News;

            return this.View(result);
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            var dbNews = this.database.News
                .FirstOrDefault(n => n.Id == id);

            if (dbNews == null)
            {
                this.ModelState.AddModelError(id.ToString(), "News not found!");
            }

            var result = new NewsByIdViewModel()
            {
                Title = dbNews.Title,
                Content = dbNews.Content,
                Category = dbNews.Category
            };

            return this.View(result);
        }
    }
}