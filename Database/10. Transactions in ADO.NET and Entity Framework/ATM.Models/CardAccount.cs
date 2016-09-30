namespace ATM.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CardAccount
    {
        public int Id { get; set; }

        [StringLength(10)]
        [Index(IsUnique=true)]
        public string CardNumber { get; set; }

        [StringLength(4)]
        public string CardPIN { get; set; }

        public decimal CardCash { get; set; }
    }
}
