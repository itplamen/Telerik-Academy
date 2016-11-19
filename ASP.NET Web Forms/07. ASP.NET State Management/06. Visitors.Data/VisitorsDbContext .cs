namespace _06.Visitors.Data
{
    using System.Data.Entity;

    using _06.Visitors.Models;

    public class VisitorsDbContext: DbContext
    {
        public VisitorsDbContext()
            :base("VisitorsDb")
        {

        }

        public IDbSet<Visitor> Visitors { get; set; }
    }
}
