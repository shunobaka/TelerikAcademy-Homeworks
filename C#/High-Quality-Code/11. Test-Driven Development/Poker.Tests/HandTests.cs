namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class HandTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void HandShouldThrowArgumentNullExceptionWhenToStringIsCalledAndCardsListIsNull()
        {
            Hand hand = new Hand(null);
            hand.ToString();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void HandShouldThrowArgumentOutOfRangeExceptionWhenToStringIsCalledAndCardsListIsEmpty()
        {
            Hand hand = new Hand(new List<ICard>());
            hand.ToString();
        }

        [TestMethod]
        public void HandShouldReturnAProperStringWhenTheCardsListIsValid()
        {
            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });
            string result = hand.ToString();
            StringBuilder expected = new StringBuilder();

            expected.AppendLine("Cards in hand:");
            foreach (Card card in hand.Cards)
            {
                expected.AppendLine(card.ToString());
            }

            Assert.AreEqual(result, expected.ToString().Trim());
        }
    }
}
