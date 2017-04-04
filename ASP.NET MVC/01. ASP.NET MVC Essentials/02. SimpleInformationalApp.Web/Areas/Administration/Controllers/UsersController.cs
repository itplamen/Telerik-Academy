namespace _02.SimpleInformationalApp.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    using Data;
    using Models.User;

    public class UsersController : Controller
    {
        private Database database = Database.Instance;

        [HttpGet]
        public ActionResult Index()
        {
            var users = new AllUsersViewModel();
            users.Users = database.Users;

            return this.View(users);
        }
    }
}