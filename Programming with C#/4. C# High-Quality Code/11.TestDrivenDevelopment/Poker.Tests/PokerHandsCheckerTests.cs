namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PokerHandsCheckerTests
    {
        private const int FIRST_HAND_IS_BIGGER = -1;
        private const int HANDS_ARE_EQUAL = 0;
        private const int SECOND_HAND_IS_BIGGER = 1;
        private IPokerHandsChecker pokerHandsChecker;

        [TestInitialize]
        public void TestInitialize()
        {
            this.pokerHandsChecker = new PokerHandsChecker();
        }

        [TestMethod]
        public void IsValidHand_True()
        {
            bool expected = true;
            bool result = this.pokerHandsChecker.IsValidHand(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsValidHand_False()
        {
            this.pokerHandsChecker.IsValidHand(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Hearts)
            }));
        }

        [TestMethod]
        public void IsStraightFlush_True()
        {
            bool expected = true;
            bool result = this.pokerHandsChecker.IsStraightFlush(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsStraightFlush_False_NotInSequence()
        {
            bool expected = false;
            bool result = this.pokerHandsChecker.IsStraightFlush(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsStraightFlush_False_DifferentSuit()
        {
            bool expected = false;
            bool result = this.pokerHandsChecker.IsStraightFlush(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsFourOfAKind_True()
        {
            bool expected = true;
            bool result = this.pokerHandsChecker.IsFourOfAKind(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsFourOfAKind_False()
        {
            bool expected = false;
            bool result = this.pokerHandsChecker.IsFourOfAKind(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsFullHouse_True()
        {
            bool expected = true;
            bool result = this.pokerHandsChecker.IsFullHouse(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Hearts)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsFullHouse_False()
        {
            bool expected = false;
            bool result = this.pokerHandsChecker.IsFullHouse(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Hearts)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsFlush_True()
        {
            bool expected = true;
            bool result = this.pokerHandsChecker.IsFlush(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Hearts)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsFlush_False_DifferentSuit()
        {
            bool expected = false;
            bool result = this.pokerHandsChecker.IsFlush(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Hearts)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsFlush_False_InSequence()
        {
            bool expected = false;
            bool result = this.pokerHandsChecker.IsFlush(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Hearts)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsStraight_True()
        {
            bool expected = true;
            bool result = this.pokerHandsChecker.IsStraight(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Clubs)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsStraight_False_NotInSequence()
        {
            bool expected = false;
            bool result = this.pokerHandsChecker.IsStraight(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsStraight_False_SameSuit()
        {
            bool expected = false;
            bool result = this.pokerHandsChecker.IsStraight(new Hand(new List<ICard>() 
            {
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsThreeOfAKind_True()
        {
            bool expected = true;
            bool result = this.pokerHandsChecker.IsThreeOfAKind(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Hearts)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsThreeOfAKind_False()
        {
            bool expected = false;
            bool result = this.pokerHandsChecker.IsThreeOfAKind(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsThreeOfAKind_False_CounterEqualToThreeButNoThreeEqualCards()
        {
            bool expected = false;
            bool result = this.pokerHandsChecker.IsThreeOfAKind(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsTwoPair_True()
        {
            bool expected = true;
            bool result = this.pokerHandsChecker.IsTwoPair(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsTwoPair_False()
        {
            bool expected = false;
            bool result = this.pokerHandsChecker.IsTwoPair(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Hearts)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsOnePair_True()
        {
            bool expected = true;
            bool result = this.pokerHandsChecker.IsOnePair(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Clubs)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsOnePair_False()
        {
            bool expected = false;
            bool result = this.pokerHandsChecker.IsOnePair(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Clubs)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsHighCard_True()
        {
            bool expected = true;
            bool result = this.pokerHandsChecker.IsHighCard(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsHighCard_False_IfIsOnePairIsTrue()
        {
            bool expected = false;
            bool result = this.pokerHandsChecker.IsHighCard(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Diamonds)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsHighCard_False_IfIsStraightFlushIsTrue()
        {
            bool expected = false;
            bool result = this.pokerHandsChecker.IsHighCard(new Hand(new List<ICard>() 
            {
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds)
            }));

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CompareHands_DifferentRank_FirstHandHasStraightFlushSecondHandHasFourOfAKind()
        {
            Hand firstHand = new Hand(new List<ICard>() 
            {
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts)
            });

            Hand secondHand = new Hand(new List<ICard>() 
            {
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Hearts)
            });

            int expected = FIRST_HAND_IS_BIGGER;
            int result = this.pokerHandsChecker.CompareHands(firstHand, secondHand);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CompareHands_DifferentRank_FirstHandHasFlushSecondHandHasFullHouse()
        {
            Hand firstHand = new Hand(new List<ICard>() 
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Hearts)
            });

            Hand secondHand = new Hand(new List<ICard>() 
            {
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Hearts)
            });

            int expected = SECOND_HAND_IS_BIGGER;
            int result = this.pokerHandsChecker.CompareHands(firstHand, secondHand);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CompareHands_DifferentRank_FirstHandHasStraightSecondHandHasThreeOfAKind()
        {
            Hand firstHand = new Hand(new List<ICard>() 
            {
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Diamonds)
            });

            Hand secondHand = new Hand(new List<ICard>() 
            {
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts)
            });

            int expected = FIRST_HAND_IS_BIGGER;
            int result = this.pokerHandsChecker.CompareHands(firstHand, secondHand);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CompareHands_DifferentRank_FirstHandHasOnePairSecondHandHasTwoPair()
        {
            Hand firstHand = new Hand(new List<ICard>() 
            {
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Diamonds)
            });

            Hand secondHand = new Hand(new List<ICard>() 
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Hearts)
            });

            int expected = SECOND_HAND_IS_BIGGER;
            int result = this.pokerHandsChecker.CompareHands(firstHand, secondHand);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CompareHands_DifferentRank_FirstHandHasOnePairSecondHandHasHighCard()
        {
            Hand firstHand = new Hand(new List<ICard>() 
            {
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            });

            Hand secondHand = new Hand(new List<ICard>() 
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Hearts)
            });

            int expected = FIRST_HAND_IS_BIGGER;
            int result = this.pokerHandsChecker.CompareHands(firstHand, secondHand);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CompareHands_SameRank_FirstHandHasBiggerCard()
        {
            Hand firstHand = new Hand(new List<ICard>() 
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades)
            });

            Hand secondHand = new Hand(new List<ICard>() 
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Spades)
            });

            int expected = FIRST_HAND_IS_BIGGER;
            int result = this.pokerHandsChecker.CompareHands(firstHand, secondHand);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CompareHands_SameRank_SecondHandHasBiggerCard()
        {
            Hand firstHand = new Hand(new List<ICard>() 
            {
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Hearts)
            });

            Hand secondHand = new Hand(new List<ICard>() 
            {
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Hearts)
            });

            int expected = SECOND_HAND_IS_BIGGER;
            int result = this.pokerHandsChecker.CompareHands(firstHand, secondHand);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CompareHands_SameRank_EqualHands()
        {
             Hand firstHand = new Hand(new List<ICard>() 
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            });

            Hand secondHand = new Hand(new List<ICard>() 
            {
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            int expected = HANDS_ARE_EQUAL;
            int result = this.pokerHandsChecker.CompareHands(firstHand, secondHand);

            Assert.AreEqual(expected, result);
        }
    }
}
