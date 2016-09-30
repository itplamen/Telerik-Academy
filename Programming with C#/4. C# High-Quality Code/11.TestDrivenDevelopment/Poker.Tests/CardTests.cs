namespace Poker.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void ToString_PrintCardTwoOfHearts()
        {
            Card card = new Card(CardFace.Two, CardSuit.Hearts);
            string expected = "2♥";
            string result = card.ToString();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToString_PrintCardTenOfClubs()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Clubs);
            string expected = "10♣";
            string result = card.ToString();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToString_PrintCardJackOfSpades()
        {
            Card card = new Card(CardFace.Jack, CardSuit.Spades);
            string expected = "J♠";
            string result = card.ToString();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToString_PrintCardKingOfDiamonds()
        {
            Card card = new Card(CardFace.King, CardSuit.Diamonds);
            string expected = "K♦";
            string result = card.ToString();

            Assert.AreEqual(expected, result);
        }
    }
}
