namespace ATM.Data
{
    using System.Data.Entity;

    using ATM.Data.Migrations;
    using ATM.Models;
    
    public class ATMDbContext : DbContext
    {
        public ATMDbContext()
            :base("ATM")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ATMDbContext, Configuration>());
        }

        public IDbSet<CardAccount> CardAccounts { get; set; }

        public IDbSet<TransactionsHistory> TransactionHistory { get; set; }
    }
}
