namespace _01.BitCalculator.Web.Models.BitCalculator
{
    using System.Collections.Generic;

    using Data;

    public class ResultViewModel
    {
        public double Quantity { get; set; }

        public IList<UnitType> Type { get; set; }

        public IList<KiloType> Kilo { get; set; }
    }
}