namespace Poker
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Contains methods for checking hand rank and comparing two hands.
    /// </summary>
    public class PokerHandsChecker : IPokerHandsChecker
    {
        private const int FIRST_HAND_IS_BIGGER = -1;
        private const int HANDS_ARE_EQUAL = 0;
        private const int SECOND_HAND_IS_BIGGER = 1;
        private const int TWO_CARD_OF_KIND = 2;
        private const int THREE_CARDS_OF_KIND = 3;
        private const int FOUR_CARDS_OF_KIND = 4;
        private const int SEQUENCE_OF_ALL_CARDS = 5;
        private const int MAX_CARDS_OF_ONE_SUIT = 5;

        /// <summary>
        /// Check if hand is valid. A hand is valid when it consists of exactly 5 different cards.
        /// </summary>
        /// <param name="hand">The hand that will be checked.</param>
        /// <returns>True if hand is valid. False if not.</returns>
        public bool IsValidHand(IHand hand)
        {
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face && hand.Cards[i].Suit == hand.Cards[j].Suit)
                    {
                        throw new ArgumentException("Player hand is NOT valid!");
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Check if hand has a straight flush. A straight flush contains five cards in sequence, all of the same suit.
        /// </summary>
        /// <example>
        /// Q♣ J♣ 10♣ 9♣ 8♣
        /// </example>
        /// <param name="hand">The hand that will be checked.</param>
        /// <returns>True if hand has a straight flush. False if not.</returns>
        public bool IsStraightFlush(IHand hand)
        {
            if (this.IsValidHand(hand) == true)
            {
                List<int> cards = this.SortCards(hand);

                // Check if all five cards are IN sequence (Straight). Return false if they are NOT in sequence
                for (int i = 0; i < cards.Count - 1; i++)
                {
                    if ((cards[i] - 1) != cards[i + 1])
                    {
                        return false;
                    }
                }

                // Check if all five cards are from same suit (Flush). Return false if they are from different suit
                for (int i = 0; i < hand.Cards.Count - 1; i++)
                {
                    if (hand.Cards[i].Suit != hand.Cards[i + 1].Suit)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Check if hand has a four of a kind .Four of a kind contains four cards of one rank and one card of different rank.
        /// </summary>
        /// <example>
        /// 9♣ 9♠ 9♦ 9♥ J♥
        /// </example>
        /// <param name="hand">The hand that will be checked.</param>
        /// <returns>True if hand has a four of a kind. False if not.</returns>
        public bool IsFourOfAKind(IHand hand)
        {
            if (this.IsValidHand(hand) == true)
            {
                List<int> cards = this.SortCards(hand);
                int equalCardsFaceCounter = 1;

                // Find four cards with equal face
                for (int i = 0; i < cards.Count - 1; i++)
                {
                    if (cards[i] == cards[i + 1])
                    {
                        equalCardsFaceCounter++;

                        if (equalCardsFaceCounter == FOUR_CARDS_OF_KIND)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        equalCardsFaceCounter = 1;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Check if hand has a full house. A full house contains three matching cards of one rank and two matching cards of different rank.
        /// </summary>
        /// <example>
        /// 3♣ 3♠ 3♦ 6♣ 6♥
        /// </example>
        /// <param name="hand">The hand that will be checked.</param>
        /// <returns>True if hand has a full house. False if not.</returns>
        public bool IsFullHouse(IHand hand)
        {
            if (this.IsValidHand(hand))
            {
                List<int> cards = this.SortCards(hand);

                // Find the three equal cards
                int threeEqualCardsCounter = 1;
                int threeEqualCards = 0;
                
                for (int i = 0; i < cards.Count - 1; i++)
                {
                    if (cards[i] == cards[i + 1])
                    {
                        threeEqualCardsCounter++;
                    }
                    else
                    {
                        threeEqualCardsCounter = 1;
                    }

                    if (threeEqualCardsCounter == THREE_CARDS_OF_KIND)
                    {
                        threeEqualCards = cards[i];
                        break;
                    }
                }

                // Find the other two equal cards, that are different from the three equal cards
                int twoEqualCardsCounter = 1;
                int twoEqualCards = 0;
                
                for (int i = 0; i < cards.Count - 1; i++)
                {
                    if ((cards[i] == cards[i + 1]) && (cards[i] != threeEqualCards))
                    {
                        twoEqualCardsCounter++;
                    }

                    if (twoEqualCardsCounter == TWO_CARD_OF_KIND)
                    {
                        twoEqualCards = cards[i];
                        break;
                    }
                }

                if ((threeEqualCardsCounter == THREE_CARDS_OF_KIND) && (twoEqualCardsCounter == TWO_CARD_OF_KIND) && (threeEqualCards != twoEqualCards))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Check if hand has a flush. A flush contains all five cards from same suit, but not in sequence.
        /// </summary>
        /// <example>
        /// Q♣ 10♣ 7♣ 6♣ 4♣
        /// </example>
        /// <param name="hand">The hand that will be checked.</param>
        /// <returns>True if hand has a flush. False if not.</returns>
        public bool IsFlush(IHand hand)
        {
            if (this.IsValidHand(hand) == true)
            {
                // Check if cards are from same suit. Return false if they are from different suit
                for (int i = 0; i < hand.Cards.Count - 1; i++)
                {
                    if (hand.Cards[i].Suit != hand.Cards[i + 1].Suit)
                    {
                        return false;
                    }
                }

                // Check if all five cards are NOT in sequence. Return false if they are IN sequence
                List<int> cards = this.SortCards(hand);
                int sequenceCounter = 1;

                for (int i = 0; i < cards.Count - 1; i++)
                {
                    if ((cards[i] - 1) == cards[i + 1])
                    {
                        sequenceCounter++;

                        if (sequenceCounter == SEQUENCE_OF_ALL_CARDS)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Check if hand has a straight. A straight contains five cards of sequential rank in at least two different suits.
        /// </summary>
        /// <example>
        /// Q♣ J♠ 10♠ 9♥ 8♥
        /// </example>
        /// <param name="hand">The hand that will be checked.</param>
        /// <returns>True if hand has a straight. False if not.</returns>
        public bool IsStraight(IHand hand)
        {
            if (this.IsValidHand(hand) == true)
            {
                List<int> cards = this.SortCards(hand);

                // Check if all five cards are IN sequence. Return false if they are NOT in sequence
                for (int i = 0; i < cards.Count - 1; i++)
                {
                    if ((cards[i] - 1) != cards[i + 1])
                    {
                        return false;
                    }
                }

                // Check if cards are from at least two different suit. Return false if they are from same suit
                int suitCounter = 1;

                for (int i = 0; i < hand.Cards.Count - 1; i++)
                {
                    if (hand.Cards[i].Suit == hand.Cards[i + 1].Suit)
                    {
                        suitCounter++;

                        if (suitCounter == MAX_CARDS_OF_ONE_SUIT)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Check if hand has a three of a kind. Three of a kind contains three cards of same rank, plus two cards which are not of this rank nor the same as each other. 
        /// </summary>
        /// <example>
        /// 2♦ 2♠ 2♣ K♠ 6♥
        /// </example>
        /// <param name="hand">The hand that will be checked.</param>
        /// <returns>True if hand has a three of a kind. False if not.</returns>
        public bool IsThreeOfAKind(IHand hand)
        {
            if (this.IsValidHand(hand) == true)
            {
                List<int> cards = this.SortCards(hand);

                // Find three equal cards from same rank. Return false if they are more or less than three
                int threeEqualCards = 0;
                int threeEqualCardsCounter = 1;

                for (int i = 0; i < cards.Count - 1; i++)
                {
                    if (cards[i] == cards[i + 1])
                    {
                        threeEqualCardsCounter++;
                        threeEqualCards = cards[i];
                    }
                }

                if (threeEqualCardsCounter != THREE_CARDS_OF_KIND)
                {
                    return false;
                }

                // Check if other two cards are NOT equal each others. Otherwise return false
                for (int i = 0; i < cards.Count - 1; i++)
                {
                    if (cards[i] == cards[i + 1] && cards[i] != threeEqualCards)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Check if hand has a two pair. A two pair contains two cards of the same rank, plus two cards of another rank (that match each other but not the first pair), plus any card not of either rank. 
        /// </summary>
        /// <example>
        /// J♥ J♣ 4♣ 4♠ 9♥
        /// </example>
        /// <param name="hand">The hand that will be checked.</param>
        /// <returns>True if hand has a two pair. False if not.</returns>
        public bool IsTwoPair(IHand hand)
        {
            if (this.IsValidHand(hand) == true)
            {
                List<int> card = this.SortCards(hand);

                int firstPairCounter = 1;
                int firstPairCards = 0;

                int secondPairCounter = 1;
                int secondPairCards = 0;

                for (int i = 0; i < card.Count - 1; i++)
                {
                    if (card[i] == card[i + 1])
                    {
                        if (firstPairCounter < TWO_CARD_OF_KIND)
                        {
                            firstPairCounter++;
                            firstPairCards = card[i];
                        }
                        else
                        {
                            secondPairCounter++;
                            secondPairCards = card[i];
                        }
                    }
                }

                if ((firstPairCounter == secondPairCounter) && (firstPairCards != secondPairCards))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Check if hand has a one pair. One pair contains two cards of one rank, plus three cards which are not of this rank nor the same as each other. 
        /// </summary>
        /// <example>
        /// 4♥ 4♠ K♠ 10♦ 5♠
        /// </example>
        /// <param name="hand">The hand that will be checked.</param>
        /// <returns>True if hand has a one pair. False if not.</returns>
        public bool IsOnePair(IHand hand)
        {
            if (this.IsValidHand(hand) == true)
            {
                List<int> cards = this.SortCards(hand);

                int twoCardsCounter = 1;

                for (int i = 0; i < cards.Count - 1; i++)
                {
                    if (cards[i] == cards[i + 1])
                    {
                        twoCardsCounter++;
                    }
                }

                if (twoCardsCounter == TWO_CARD_OF_KIND)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Check if hand has a high card. A high-card or no-pair hand is made of any five cards not meeting any of the above requirements. 
        /// </summary>
        /// <example>
        /// K♥ J♥ 8♣ 7♦ 4♠
        /// </example>
        /// <param name="hand">The hand that will be checked.</param>
        /// <returns>True if hand has a high card. False if not.</returns>
        public bool IsHighCard(IHand hand)
        {
            if (this.IsValidHand(hand) == true)
            {
                if (this.IsStraightFlush(hand) == false && this.IsFourOfAKind(hand) == false &&
                    this.IsFullHouse(hand) == false && this.IsFlush(hand) == false &&
                    this.IsStraight(hand) == false && this.IsThreeOfAKind(hand) == false &&
                    this.IsTwoPair(hand) == false && this.IsOnePair(hand) == false)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Compare two hand by rank and check which hand is bigger or if both hands are equal.
        /// </summary>
        /// <param name="firstHand">The first hand that will be checked.</param>
        /// <param name="secondHand">The second hand that will be checked.</param>
        /// <returns>If first hand is bigger returns -1. If both hands are equal returns 0. If second hand is bigger returns 1.</returns>
        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            int firstHandRank = this.CheckHandRank(firstHand);
            int secondHandRank = this.CheckHandRank(secondHand);
            
            // If hands are from different rank
            if (firstHandRank > secondHandRank)
            {
                return FIRST_HAND_IS_BIGGER;
            }
            else if (firstHandRank < secondHandRank)
            {
                return SECOND_HAND_IS_BIGGER;
            }

            // If hands are from same rank, compare their highest cards
            if (firstHandRank == secondHandRank)
            {
                List<int> firstHandCards = this.SortCards(firstHand);
                List<int> secondHandCards = this.SortCards(secondHand);

                int handsLength = firstHand.Cards.Count;

                for (int i = 0; i < handsLength; i++)
                {
                    if (firstHandCards[i] > secondHandCards[i])
                    {
                        return FIRST_HAND_IS_BIGGER;
                    }
                    else if (firstHandCards[i] < secondHandCards[i])
                    {
                        return SECOND_HAND_IS_BIGGER;
                    }
                }
            }

            return HANDS_ARE_EQUAL;
        }

        /// <summary>
        /// Check hand rank starting from highest rank.
        /// </summary>
        /// <param name="hand">The hand that will be checked.</param>
        /// <returns>Hand rank as integer.</returns>
        private int CheckHandRank(IHand hand)
        {
            int handRank = 0;

            if (this.IsStraightFlush(hand) == true)
            {
                handRank = (int)HandRank.IsStraightFlushRank;
            }
            else if (this.IsFourOfAKind(hand) == true)
            {
                handRank = (int)HandRank.IsFourOfAKindRank;
            }
            else if (this.IsFullHouse(hand) == true)
            {
                handRank = (int)HandRank.IsFullHouseRank;
            }
            else if (this.IsFlush(hand) == true)
            {
                handRank = (int)HandRank.IsFlushRank;
            }
            else if (this.IsStraight(hand) == true)
            {
                handRank = (int)HandRank.IsStraightRank;
            }
            else if (this.IsThreeOfAKind(hand) == true)
            {
                handRank = (int)HandRank.IsThreeOfAKindRank;
            }
            else if (this.IsTwoPair(hand) == true)
            {
                handRank = (int)HandRank.IsTwoPairRank;
            }
            else if (this.IsOnePair(hand) == true)
            {
                handRank = (int)HandRank.IsOnePairRank;
            }
            else if (this.IsHighCard(hand) == true)
            {
                handRank = (int)HandRank.IsHighCardRank;
            }

            return handRank;
        }

        /// <summary>
        /// Sort cards in descending order using Selection sort algorithm. <see cref="http://en.wikipedia.org/wiki/Selection_sort"/>
        /// </summary>
        /// <param name="hand">The hand that will sorted.</param>
        /// <returns>New List of integers that contains sorted cards.</returns>
        private List<int> SortCards(IHand hand)
        {
            List<int> cards = new List<int>();

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                cards.Add((int)hand.Cards[i].Face);
            }

            // Selection sort algorithm
            for (int i = 0; i < cards.Count; i++)
            {
                int maxElement = cards[i];
                int maxElementIndex = 0;

                for (int j = i + 1; j < cards.Count; j++)
                {
                    if (cards[j] > maxElement)
                    {
                        maxElement = cards[j];
                        maxElementIndex = j;
                    }
                }

                if (maxElement != cards[i])
                {
                    cards[maxElementIndex] = cards[i];
                    cards[i] = maxElement;
                }
            }

            return cards;
        }
    }
}
