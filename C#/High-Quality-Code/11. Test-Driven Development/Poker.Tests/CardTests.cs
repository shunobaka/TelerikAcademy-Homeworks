namespace Poker.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void CardShouldReturnProperStringWhenToStringIsCalled()
        {
            Card firstCard = new Card(CardFace.Ace, CardSuit.Diamonds);
            string firstResult = firstCard.ToString();
            string firstExpected = "Ace of Diamonds";

            Card secondCard = new Card(CardFace.Queen, CardSuit.Spades);
            string secondResult = secondCard.ToString();
            string secondExpected = "Queen of Spades";

            Assert.AreEqual(firstResult, firstExpected);
            Assert.AreEqual(secondResult, secondExpected);
        }
    }
}
