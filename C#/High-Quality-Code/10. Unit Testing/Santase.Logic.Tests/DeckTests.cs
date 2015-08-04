namespace Santase.Logic.Tests
{
    using System;
    using NUnit.Framework;
    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void DecksShouldBeOrderedDifferentlyOnSeparateInitializations()
        {
            var deckOne = new Deck();
            var deckTwo = new Deck();
            for (int i = 1; i <= 24; i++)
            {
                var cardOne = deckOne.GetNextCard();
                var cardTwo = deckTwo.GetNextCard();
                if (cardOne != cardTwo)
                {
                    break;
                }

                if (i == 24)
                {
                    Assert.Fail();
                }
            }
        }

        [Test]
        [ExpectedException(typeof(InternalGameException))]
        public void DeckShouldThrowAnExceptionWhenDrawingMoreCardsThanInTheDeck()
        {
            var deck = new Deck();
            for (int i = 1; i <= 25; i++)
            {
                deck.GetNextCard();
            }
        }

        [Test]
        public void DeckShouldReturnAValidCardWhenAskedForTrumpCard()
        {
            var deck = new Deck();
            var trumpCard = deck.GetTrumpCard;
            Assert.IsInstanceOf(typeof(Card), trumpCard);
        }

        /*[Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeckShouldThrowArgumentNullExceptionWhenTryingToChangeTrumpCardToNull()
        {
            var deck = new Deck();
            deck.ChangeTrumpCard(null);
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DeckShouldThrowInvalidOperationExceptionWhenTryingToChangeTrumpCardToItself()
        {
            var deck = new Deck();
            var trumpCard = deck.GetTrumpCard;
            deck.ChangeTrumpCard(trumpCard);
        }*/

        [Test]
        public void DeckShouldReturnProperTrumpCardAfterChangingIt()
        {
            var deck = new Deck();
            var newTrumpCard = new Card(CardSuit.Heart, CardType.Ace);
            deck.ChangeTrumpCard(newTrumpCard);
            var currentTrumpCard = deck.GetTrumpCard;
            Assert.AreSame(newTrumpCard, currentTrumpCard);
        }

        [Test]
        [TestCase(10)]
        [TestCase(0)]
        [TestCase(24)]
        public void DeckShouldReturnAProperValueWhenAskedForNumberOfCardsLeft(int cardsToDraw)
        {
            var deck = new Deck();
            for (int i = 0; i < cardsToDraw; i++)
            {
                deck.GetNextCard();
            }
            var cardsLeft = deck.CardsLeft;
            Assert.AreEqual(cardsLeft, 24 - cardsToDraw);
        }
    }
}
