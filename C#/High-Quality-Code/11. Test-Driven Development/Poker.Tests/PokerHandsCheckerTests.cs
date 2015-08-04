namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class PokerHandsCheckerTests
    {
        [TestCategory("IsValidHandTests")]
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidHandCheckerShouldThrowArgumentNullExceptionWhenHandIsNull()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            checker.IsValidHand(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidHandCheckerShouldThrowArgumentNullExceptionWhenHandsCardsListIsNull()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(null);
            checker.IsValidHand(hand);
        }

        [TestMethod]
        public void ValidHandCheckerShouldReturnFalseWhenHandHasLessThanFiveCards()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs)
            });
            var result = checker.IsValidHand(hand);
            bool expected = false;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidHandCheckerShouldThrowArgumentOutOfRangeExceptionWhenHandHasMoreThanFiveCards()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds)
            });
            checker.IsValidHand(hand);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidHandCheckerShouldThrowArgumentExceptionWhenTheHandHasTheSameCardMoreThanOnce()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs)
            });
            checker.IsValidHand(hand);
        }

        [TestMethod]
        public void ValidHandCheckerShouldReturnTrueWhenTheHandIsAValidOne()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs)
            });
            checker.IsValidHand(hand);
        }

        [TestCategory("IsStraightFlushTests")]
        [TestMethod]
        public void StraightFlushHandCheckerShouldReturnFalseWhenHandIsFlush()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds)
            });
            bool result = checker.IsStraightFlush(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void StraightFlushHandCheckerShouldReturnFalseWhenHandIsStraight()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Hearts)
            });
            bool result = checker.IsStraightFlush(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void StraightFlushHandCheckerShouldReturnTrueWhenTheHandIsAValidStraightFlushHand()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs)
            });
            bool result = checker.IsStraightFlush(hand);
            bool expected = true;

            Assert.AreEqual(result, expected);
        }

        [TestCategory("IsFourOfAKindTests")]
        [TestMethod]
        public void FourOfAKindCheckerShouldReturnFalseWhenThereAreThreeDifferentFacesInTheHand()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs)
            });
            bool result = checker.IsFourOfAKind(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void FourOfAKindCheckerShouldReturnFalseWhenThereAreTwoDifferentFacesInTheHandButWithThreeAndTwoCardsOfThem()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds)
            });
            bool result = checker.IsFourOfAKind(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void FourOfAKindCheckerShouldReturnTrueWhenTheHandIsValidFourOfAKindHand()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds)
            });
            bool result = checker.IsFourOfAKind(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestCategory("IsFullHouseTests")]
        [TestMethod]
        public void FullHouseCheckerShouldReturnFalseWhenHandIsThreeOfAKind()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs)
            });
            bool result = checker.IsFullHouse(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void FullHouseCheckerShouldReturnFalseWhenHandIsPair()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs)
            });
            bool result = checker.IsFullHouse(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void FullHouseCheckerShouldReturnTrueWhenHandIsAValidFullHouse()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds)
            });
            bool result = checker.IsFullHouse(hand);
            bool expected = true;

            Assert.AreEqual(result, expected);
        }

        [TestCategory("IsFlushTests")]
        [TestMethod]
        public void FlushHandCheckerShouldReturnFalseWhenHandIsNotFlush()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs)
            });
            bool result = checker.IsFlush(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void FlushHandCheckerShouldReturnFalseWhenHandIsStraightFlush()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs)
            });
            bool result = checker.IsFlush(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void FlushHandCheckerShouldReturnTrueWhenTheHandIsAValidFlushHand()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs)
            });
            bool result = checker.IsFlush(hand);
            bool expected = true;

            Assert.AreEqual(result, expected);
        }

        [TestCategory("IsStraightTests")]
        [TestMethod]
        public void StraightHandCheckerShouldReturnFalseWhenHandIsNotAStraight()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs)
            });
            bool result = checker.IsStraight(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void StraightHandCheckerShouldReturnFalseWhenHandIsStraightFlush()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs)
            });
            bool result = checker.IsStraight(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void StraightHandCheckerShouldReturnTrueWhenTheHandIsAValidStraightHand()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs)
            });
            bool result = checker.IsStraight(hand);
            bool expected = true;

            Assert.AreEqual(result, expected);
        }

        [TestCategory("IsThreeOfAKindTests")]
        [TestMethod]
        public void ThreeOfAKindCheckerShouldReturnFalseWhenTheHandIsPair()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs)
            });
            bool result = checker.IsThreeOfAKind(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void ThreeOfAKindCheckerShouldReturnFalseWhenTheHandIsFourOfAKind()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs)
            });
            bool result = checker.IsThreeOfAKind(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void ThreeOfAKindCheckerShouldReturnFalseWhenTheHandIsFullHouse()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds)
            });
            bool result = checker.IsThreeOfAKind(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void ThreeOfAKindCheckerShouldReturnTrueWhenTheHandIsValidThreeOfAKind()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds)
            });
            bool result = checker.IsThreeOfAKind(hand);
            bool expected = true;

            Assert.AreEqual(result, expected);
        }

        [TestCategory("IsTwoPairTests")]
        [TestMethod]
        public void TwoPairCheckerShouldReturnFalseWhenHandIsAPair()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs)
            });
            bool result = checker.IsTwoPair(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TwoPairCheckerShouldReturnFalseWhenHandIsFullHouse()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds)
            });
            bool result = checker.IsTwoPair(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TwoPairCheckerShouldReturnTrueWhenHandIsValidTwoPair()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds)
            });
            bool result = checker.IsTwoPair(hand);
            bool expected = true;

            Assert.AreEqual(result, expected);
        }

        [TestCategory("IsOnePairTests")]
        [TestMethod]
        public void OnePairCheckerShouldReturnFalseWhenHandIsTwoPair()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds)
            });
            bool result = checker.IsOnePair(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void OnePairCheckerShouldReturnFalseWhenHandIsFullHouse()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds)
            });
            bool result = checker.IsOnePair(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void OnePairCheckerShouldReturnTrueWhenHandIsValidOnePair()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds)
            });
            bool result = checker.IsOnePair(hand);
            bool expected = true;

            Assert.AreEqual(result, expected);
        }

        [TestCategory("IsHighCardTests")]
        [TestMethod]
        public void HighCardCheckerShouldReturnFalseWhenHandIsStraightFlush()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs)
            });
            bool result = checker.IsHighCard(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void HighCardCheckerShouldReturnFalseWhenHandIsFourOfAKind()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds)
            });
            bool result = checker.IsHighCard(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void HighCardCheckerShouldReturnFalseWhenHandIsFullHouse()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds)
            });
            bool result = checker.IsHighCard(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void HighCardCheckerShouldReturnFalseWhenHandIsFlush()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs)
            });
            bool result = checker.IsHighCard(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void HighCardCheckerShouldReturnFalseWhenHandIsStraight()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs)
            });
            bool result = checker.IsHighCard(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void HighCardCheckerShouldReturnFalseWhenHandIsThreeOfAKind()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds)
            });
            bool result = checker.IsHighCard(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void HighCardCheckerShouldReturnFalseWhenHandIsTwoPair()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds)
            });
            bool result = checker.IsHighCard(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void HighCardCheckerShouldReturnFalseWhenHandIsOnePair()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds)
            });
            bool result = checker.IsHighCard(hand);
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void HighCardCheckerShouldReturnTrueWhenHandIsHighCard()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds)
            });
            bool result = checker.IsHighCard(hand);
            bool expected = true;

            Assert.AreEqual(result, expected);
        }
    }
}
