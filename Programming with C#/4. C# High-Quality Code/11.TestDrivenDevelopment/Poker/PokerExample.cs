//01. Write a class Card implementing the ICard interface. Implement the properties. Write a constructor. 
//Implement the ToString() method. Test all cases.

//02. Write a class Hand implementing the IHand interface. Implement the properties. Write a constructor. 
//Implement the ToString() method. Test all cases.

//03. Write a class PokerHandsChecker (+ tests) and start implementing the IPokerHandsChecker interface. 
//Implement the IsValidHand(IHand). A hand is valid when it consists of exactly 5 different cards.

//04. Implement IPokerHandsChecker.IsFlush(IHand) method. Follow the official poker rules from Wikipedia: http://en.wikipedia.org/wiki/List_of_poker_hands

//05. Implement IsFourOfAKind(IHand) method. Did you test all the scenarios?

//06. * Implement the other check for poker hands: IsHighCard(IHand hand), IsOnePair(IHand hand), 
//IsTwoPair(IHand hand), IsThreeOfAKind(IHand hand), IsFullHouse(IHand hand), IsStraight(IHand hand) and 
//IsStraightFlush(IHand hand). Did you test all the scenarios well?

//07. * Implement a card comparison logic for Poker hands (+ tests). CompareHands(…) should return -1, 0 or 1.

namespace Poker
{
    using System;
    using System.Collections.Generic;

    public class PokerExample
    {
        private const int FIRST_HAND_IS_BIGGER = -1;
        private const int HANDS_ARE_EQUAL = 0;
        private const int SECOND_HAND_IS_BIGGER = 1;

        private static void Main()
        {
            ICard card = new Card(CardFace.Ace, CardSuit.Clubs);
            Console.WriteLine("---------- PRINT ONE CARD ----------");
            Console.WriteLine(card + "\n");

            IHand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });
            Console.WriteLine("---------- PRINT ONE HAND ----------");
            Console.WriteLine(hand + "\n");

            IPokerHandsChecker checker = new PokerHandsChecker();
            Console.WriteLine("---------- CHECK HAND ----------");
            Console.WriteLine("Is valid: " + checker.IsValidHand(hand));
            Console.WriteLine("Is one pair: " + checker.IsOnePair(hand));
            Console.WriteLine("Is two pair: " + checker.IsTwoPair(hand) + "\n");

            // Copmpare both hands
            IHand firstHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs)
            });
            Console.WriteLine("---------- PRINT FIRST HAND ----------");
            Console.WriteLine(firstHand + "\n");

            IHand secondHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            });
            Console.WriteLine("---------- PRINT SECOND HAND ----------");
            Console.WriteLine(secondHand + "\n");

            Console.WriteLine("Is first hand valid: " + checker.IsValidHand(firstHand));
            Console.WriteLine("Is secondHand valid: " + checker.IsValidHand(secondHand));

            string result = string.Empty;
            if (checker.CompareHands(firstHand, secondHand) == FIRST_HAND_IS_BIGGER)
            {
                result = firstHand.ToString() + " > " + secondHand.ToString();
            }
            else if (checker.CompareHands(firstHand, secondHand) == SECOND_HAND_IS_BIGGER)
            {
                result = firstHand.ToString() + " < " + secondHand.ToString();
            }
            else
            {
                result = firstHand.ToString() + " = " + secondHand.ToString();
            }

            Console.WriteLine("Compare hands: " + result + "\n");
        }
    }
}
