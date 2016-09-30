// 01. Suppose you are creating a simple engine for an ATM machine. Create a new database "ATM" in SQL Server
// to hold the accounts of the card holders and the balance (money) for each account. Add a new table
// CardAccounts with the following fields:
// Id (int)
// CardNumber (char(10))
// CardPIN (char(4))
// CardCash (money)
// Add a few sample records in the table.

// 02. Using transactions write a method which retrieves some money (for example $200) from certain account. The retrieval is successful when the
// following sequence of sub-operations is completed successfully:
//  A query checks if the given CardPIN and CardNumber are valid.
//  The amount on the account (CardCash) is evaluated to see whether it is bigger than the requested sum (more than $200).
//  The ATM machine pays the required sum (e.g. $200) and stores in the table CardAccounts the new amount (CardCash = CardCash - 200).

namespace ATM.ConsoleClient
{
    using System;
    using System.Linq;

    using ATM.Data;
    using ATM.Models;

    public class Program
    {
        private const int CARD_NUMBER_LENGTH = 10;
        private const int CARD_PIN_LENGTH = 4;

        public static void Main()
        {
            var db = new ATMDbContext();
            db.Database.Initialize(true);
            RetrieveMoney(db, "1234", "1234567890", 10);
        }

        private static void RetrieveMoney(ATMDbContext db, string cardPIN, string cardNumber, decimal money)
        {
            if (!IsCardPINValid(cardPIN))
            {
                throw new ArgumentException("Invalid Card PIN! There are incorrect symbols or the PIN length is different than " + CARD_PIN_LENGTH);
            }

            if (!IsCardNumberValid(cardNumber))
            {
                throw new ArgumentException("Invalid Card Number! There are incorrect symbols or the number length is different than " + CARD_NUMBER_LENGTH);
            }

            var account = db.CardAccounts
                .FirstOrDefault(ca => ca.CardNumber == cardNumber && ca.CardPIN == cardPIN);

            if (account.CardCash < money)
            {
                Console.WriteLine("Erro. No money!");
            }
            else
            {
                account.CardCash -= money;
                db.SaveChanges();

                var transactionHistoy = new TransactionsHistory
                {
                    CardNumber = account.CardNumber,
                    TransactionDate = DateTime.Now,
                    Ammount = account.CardCash
                };

                db.TransactionHistory.Add(transactionHistoy);
                db.SaveChanges();
            }
        }

        private static bool IsCardPINValid(string cardPIN)
        {
            return !string.IsNullOrEmpty(cardPIN) && cardPIN.Trim().Length == CARD_PIN_LENGTH;
        }

        private static bool IsCardNumberValid(string cardNumber)
        {
            return !string.IsNullOrEmpty(cardNumber) && cardNumber.Trim().Length == CARD_NUMBER_LENGTH;
        }
    }
}
