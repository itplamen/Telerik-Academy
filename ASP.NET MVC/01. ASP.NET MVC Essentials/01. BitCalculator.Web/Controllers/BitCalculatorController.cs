namespace _01.BitCalculator.Web.Controllers
{
    using System.Web.Mvc;

    using Data;
    using Models.BitCalculator;

    public class BitCalculatorController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var database = Database.Instance;

            var result = new ResultViewModel()
            {
                Quantity = 1,
                Type = database.UnitTypes,
                Kilo = database.KiloTypes
            };

            return this.View(result);
        }

        [HttpPost]
        public ActionResult Index(InputViewModel model)
        {
            // Implement valid bit calculation

            var database = Database.Instance;

            var result = new ResultViewModel()
            {
                Quantity = model.Quantity * 8,
                Kilo = database.KiloTypes,
                Type = database.UnitTypes
            };

            return this.View(result);
        }
    }
}