namespace ATM.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using ATM.Models;

    public sealed class Configuration : DbMigrationsConfiguration<ATMDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = false;

        }

        protected override void Seed(ATMDbContext context)
        {
            if (!context.CardAccounts.Any())
            {
                var firstCardAccount = new CardAccount
                {
                    CardNumber = "1234567890",
                    CardPIN = "1234",
                    CardCash = 200
                };

                var secondCardAccount = new CardAccount
                {
                    CardNumber = "0987654321",
                    CardPIN = "4321",
                    CardCash = 10000
                };

                var thirdCardAccount = new CardAccount
                {
                    CardNumber = "1010298177",
                    CardPIN = "0000",
                    CardCash = 370
                };

                context.CardAccounts.Add(firstCardAccount);
                context.CardAccounts.Add(secondCardAccount);
                context.CardAccounts.Add(thirdCardAccount);
                context.SaveChanges();
            }
        }
    }
}
