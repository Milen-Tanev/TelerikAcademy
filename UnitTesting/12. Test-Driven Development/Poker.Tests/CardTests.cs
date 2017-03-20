namespace Poker.Tests
{
    using NUnit.Framework;
    using Poker;

    [TestFixture]
    public class CardTests
    {
        [TestCase(CardFace.Ace, CardSuit.Spades)]
        [TestCase(CardFace.King, CardSuit.Clubs)]
        [TestCase(CardFace.Queen, CardSuit.Spades)]
        [TestCase(CardFace.Jack, CardSuit.Diamonds)]
        [TestCase(CardFace.Ten, CardSuit.Diamonds)]
        [TestCase(CardFace.Nine, CardSuit.Hearts)]
        [TestCase(CardFace.Eight, CardSuit.Clubs)]
        [TestCase(CardFace.Seven, CardSuit.Hearts)]
        [TestCase(CardFace.Six, CardSuit.Hearts)]
        [TestCase(CardFace.Five, CardSuit.Diamonds)]
        [TestCase(CardFace.Four, CardSuit.Clubs)]
        [TestCase(CardFace.Three, CardSuit.Spades)]
        [TestCase(CardFace.Two, CardSuit.Diamonds)]
        public void Card_TestToString_MustBeEqual(CardFace face, CardSuit suit)
        {
            Card card = new Card(face, suit);
            
            Assert.AreEqual(string.Format("{0} of {1}",face, suit), card.ToString());
        }
    }
}
