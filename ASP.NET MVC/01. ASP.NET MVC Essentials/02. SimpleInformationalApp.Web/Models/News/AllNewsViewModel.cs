namespace _02.SimpleInformationalApp.Web.Models.News
{
    using System.Collections.Generic;

    using Data.Models;

    public class AllNewsViewModel
    {
        public IList<News> News{ get; set; }
    }
}