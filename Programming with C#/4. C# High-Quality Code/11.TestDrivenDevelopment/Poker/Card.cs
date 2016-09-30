namespace Poker
{
    using System;

    /// <summary>
    /// Create card with face and suit.
    /// </summary>
    public class Card : ICard
    {
        private const int MAX_CARD_FASE_AS_NUMBER = (int)CardFace.Ten;

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        /// <summary>
        /// Print card face and suit.
        /// </summary>
        /// <example>
        /// <code>
        /// ICard card = new Card(CardFace.Ace, CardSuit.Diamonds);
        /// Console.WriteLine(card); // Output: A♦
        /// </code>
        /// </example>
        /// <returns>Card face and suit as a string.</returns>
        public override string ToString()
        {
            int cardFaceNumber = (int)this.Face;
            string cardFace = string.Empty;

            if (cardFaceNumber <= MAX_CARD_FASE_AS_NUMBER)
            {
                cardFace = cardFaceNumber.ToString();
            }
            else
            {
                // Get first letter from card
                cardFace = this.Face.ToString()[0].ToString();
            }

            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    cardFace += "♣";
                    break;
                case CardSuit.Diamonds:
                    cardFace += "♦";
                    break;
                case CardSuit.Hearts:
                    cardFace += "♥";
                    break;
                case CardSuit.Spades:
                    cardFace += "♠";
                    break;
                default:
                    throw new InvalidOperationException("Invalid suit: " + this.Suit);
            }

            return cardFace;
        }
    }
}
