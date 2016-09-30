namespace ATM.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class TransactionsHistory
    {
        public int Id { get; set; }

        [StringLength(10)]
        [Index(IsUnique=true)]
        public string CardNumber { get; set; }

        public DateTime TransactionDate { get; set; }

        public decimal Ammount { get; set; }
    }
}
