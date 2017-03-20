namespace Poker.Tests
{
    using NUnit.Framework;
    using Poker;
    using System.Collections.Generic;

    [TestFixture]
    class PokerHandsCheckerTests
    {

        PokerHandsChecker checker = new PokerHandsChecker();


        [Test]
        public void PokerHandsChecker_IsValidIHandWithTwoEqualCards_MustBeFalse()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds)
            };

            Hand hand = new Hand(cards);

            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [Test]
        public void PokerHandsChecker_IsValidIHandWithLessThanFiveCards_MustBeFalse()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds),
            };

            Hand hand = new Hand(cards);

            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [Test]
        public void PokerHandsChecker_IsValidIHandWithValidCards_MustBeTrue()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            };

            Hand hand = new Hand(cards);

            Assert.IsTrue(checker.IsValidHand(hand));
        }

        [TestCase(CardSuit.Spades)]
        [TestCase(CardSuit.Hearts)]
        [TestCase(CardSuit.Diamonds)]
        [TestCase(CardSuit.Clubs)]
        public void PokerHandsChecker_IsFlushIHand_MustBeTrue(CardSuit suit)
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, suit),
                new Card(CardFace.King, suit),
                new Card(CardFace.Queen, suit),
                new Card(CardFace.Jack, suit),
                new Card(CardFace.Ten, suit)
            };

            Hand hand = new Hand(cards);

            Assert.IsTrue(checker.IsFlush(hand));
        }

        [Test]
        public void PokerHandsChecker_IsFlushIHand_MustBeFalse()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            };

            Hand hand = new Hand(cards);

            Assert.IsFalse(checker.IsFlush(hand));
        }

        [Test]
        public void PokerHandsChecker_IsFourOfAKind_MustBeTrue()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            };

            Hand hand = new Hand(cards);

            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }

        [Test]
        public void PokerHandsChecker_IsFourOfAKind_MustBeFalse()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds)
            };

            Hand hand = new Hand(cards);

            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }
    }
}
