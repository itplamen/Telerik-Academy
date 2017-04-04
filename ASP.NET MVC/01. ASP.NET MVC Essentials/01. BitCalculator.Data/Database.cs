namespace _01.BitCalculator.Data
{
    using System.Collections.Generic;

    public sealed class Database
    {
        private static Database instance;

        private Database()
        {
            this.UnitTypes = new List<UnitType>();

            this.UnitTypes.Add(new UnitType() { Name = "Bit", Abbreviation = "b", Value = 0 });
            this.UnitTypes.Add(new UnitType() { Name = "Byte", Abbreviation = "B", Value = 0 });
            this.UnitTypes.Add(new UnitType() { Name = "Kilobit", Abbreviation = "Kb", Value = 0 });
            this.UnitTypes.Add(new UnitType() { Name = "Kilobyte", Abbreviation = "KB", Value = 0 });
            this.UnitTypes.Add(new UnitType() { Name = "Megabit", Abbreviation = "Mb", Value = 0 });
            this.UnitTypes.Add(new UnitType() { Name = "Megabyte", Abbreviation = "MB", Value = 0 });
            this.UnitTypes.Add(new UnitType() { Name = "Gigabit", Abbreviation = "Gb", Value = 0 });
            this.UnitTypes.Add(new UnitType() { Name = "Gigabyte", Abbreviation = "GB", Value = 0 });
            this.UnitTypes.Add(new UnitType() { Name = "Terabit", Abbreviation = "Tb", Value = 0 });
            this.UnitTypes.Add(new UnitType() { Name = "Terabyte", Abbreviation = "TB", Value = 0 });
            this.UnitTypes.Add(new UnitType() { Name = "Petabit", Abbreviation = "Pb", Value = 0 });
            this.UnitTypes.Add(new UnitType() { Name = "Petabyte", Abbreviation = "PB", Value = 0 });
            this.UnitTypes.Add(new UnitType() { Name = "Exabit", Abbreviation = "Eb", Value = 0 });
            this.UnitTypes.Add(new UnitType() { Name = "Exabyte", Abbreviation = "EB", Value = 0 });
            this.UnitTypes.Add(new UnitType() { Name = "Zettabit", Abbreviation = "Zb", Value = 0 });
            this.UnitTypes.Add(new UnitType() { Name = "Zettabyte", Abbreviation = "ZB", Value = 0 });
            this.UnitTypes.Add(new UnitType() { Name = "Youttabit", Abbreviation = "Yb", Value = 0 });
            this.UnitTypes.Add(new UnitType() { Name = "Youttabyte", Abbreviation = "TB", Value = 0 });

            this.KiloTypes = new List<KiloType>();
            this.KiloTypes.Add(new KiloType() { Value = 1000 });
            this.KiloTypes.Add(new KiloType() { Value = 1024 });
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

        public IList<UnitType> UnitTypes { get; private set; }

        public IList<KiloType> KiloTypes { get; private set; }
    }
}
