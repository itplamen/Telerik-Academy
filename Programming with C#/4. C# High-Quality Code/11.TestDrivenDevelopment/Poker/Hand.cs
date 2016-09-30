namespace Poker
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Create hand with five cards.
    /// </summary>
    public class Hand : IHand
    {
        private const int CARDS_IN_HAND = 5; 

        public Hand(IList<ICard> cards)
        {
            if (cards.Count < CARDS_IN_HAND || cards.Count > CARDS_IN_HAND)
            {
                throw new ArgumentOutOfRangeException("Player hand cannot contains less or more than 5 cards!");
            }

            this.Cards = cards;
        }

        public IList<ICard> Cards { get; private set; }

        /// <summary>
        /// Print hand that contains 5 cards.
        /// </summary>
        /// <example>
        /// <code>
        /// IHand hand = new Hand(new List<ICard>() 
        /// { 
        ///     new Card(CardFace.Ace, CardSuit.Clubs),
        ///     new Card(CardFace.Ace, CardSuit.Diamonds),
         ///    new Card(CardFace.King, CardSuit.Hearts),
        ///     new Card(CardFace.King, CardSuit.Spades),
        ///     new Card(CardFace.Seven, CardSuit.Diamonds),
        /// });
        /// Console.WriteLine(hand + "\n"); // Output: A♣ A♦ K♥ K♠ 7♦
        /// </code>
        /// </example>
        /// <returns>Hand as a string.</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < this.Cards.Count; i++)
            {
                if (i == this.Cards.Count - 1)
                {
                    builder.Append(this.Cards[i]);
                }
                else
                {
                    builder.Append(this.Cards[i] + " ");
                }
            }

            return builder.ToString();
        }
    }
}
