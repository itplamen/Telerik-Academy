namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void ToString_PrintPlayerHandWithFiveCards()
        {
            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Hearts)
            });

            string expected = "K♦ 6♠ 3♣ Q♥ 7♥";
            string result = hand.ToString();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_PlayerHandSmallerThanFiveCards()
        {
            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Hearts)
            });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_PlayerHandBiggerThanFiveCards()
        {
            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds)
            });
        }
    }
}
