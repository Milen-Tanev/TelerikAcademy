namespace Poker.Tests
{
    using NUnit.Framework;
    using Poker;
    using System.Collections.Generic;

    [TestFixture]
    public class HandTests
    {

        [Test]
        public void Hand_TestToString_MustBeEqual()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs)
            };

            Hand hand = new Hand(cards);


            Assert.AreEqual("Ace of Spades, King of Clubs, Queen of Hearts, Jack of Diamonds, Ten of Clubs", hand.ToString());
        }
    }
}