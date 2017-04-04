namespace _02.SimpleInformationalApp.Web.Areas.Administration.Models.User
{
    using System.Collections.Generic;

    using Data.Models;

    public class AllUsersViewModel
    {
        public IList<User> Users { get; set; }
    }
}