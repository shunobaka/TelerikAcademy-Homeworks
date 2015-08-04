using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("The hand shouldn't be null.");
            }

            if (hand.Cards == null)
            {
                throw new ArgumentNullException("The list of cards shouldn't be null.");
            }

            if (hand.Cards.Count > 5)
            {
                throw new ArgumentOutOfRangeException("The hand should have exactly 5 cards.");
            }

            IList<ICard> uniqueCards = new List<ICard>();

            foreach (Card card in hand.Cards)
            {
                foreach (Card uniqueCard in uniqueCards)
                {
                    if (card.ToString() == uniqueCard.ToString())
                    {
                        throw new ArgumentException("The hand cannot have the same card twice.");
                    }
                }
                uniqueCards.Add(card);
            }

            if (hand.Cards.Count < 5)
            {
                return false;
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }

            CardSuit suitToCheck = hand.Cards[0].Suit;
            bool isFlush = hand.Cards.All(x => x.Suit == suitToCheck);
            List<ICard> orderedCardsInHand = hand.Cards.OrderBy(x => (int)x.Face).ToList();
            bool isStraight = true;

            for (int i = 1; i < orderedCardsInHand.Count; i++)
            {
                int previousCardFace = (int)orderedCardsInHand[i - 1].Face;
                int currentCardFace = (int)orderedCardsInHand[i].Face;

                if (currentCardFace != previousCardFace + 1)
                {
                    isStraight = false;
                    break;
                }
            }

            return isFlush && isStraight;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }

            var group = hand.Cards.GroupBy(card => card.Face);
            return group.Any(gr => gr.Count() == 4);
        }

        public bool IsFullHouse(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }

            var groups = hand.Cards.GroupBy(x => x.Face);
            return groups.Any(x => x.Count() == 3) && groups.Any(x => x.Count() == 2);
        }

        public bool IsFlush(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }

            CardSuit suitToCheck = hand.Cards[0].Suit;
            bool isFlush = hand.Cards.All(x => x.Suit == suitToCheck);
            bool isStraightFlush = IsStraightFlush(hand);

            return isFlush && !isStraightFlush;
        }

        public bool IsStraight(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }

            var orderedCardsInHand = hand.Cards.OrderBy(x => (int)x.Face).ToList();
            bool isStraight = true;

            for (int i = 1; i < orderedCardsInHand.Count; i++)
            {
                int previousCardFace = (int)orderedCardsInHand[i - 1].Face;
                int currentCardFace = (int)orderedCardsInHand[i].Face;

                if (currentCardFace != previousCardFace + 1)
                {
                    isStraight = false;
                    break;
                }
            }

            bool isStraightFlush = IsStraightFlush(hand);

            return isStraight && !isStraightFlush;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }

            var groups = hand.Cards.GroupBy(x => x.Face);
            return groups.Any(x => x.Count() == 3) && !IsFullHouse(hand);
        }

        public bool IsTwoPair(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }

            var groups = hand.Cards.GroupBy(x => x.Face);
            return groups.Count(x => x.Count() == 2) == 2;
        }

        public bool IsOnePair(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }

            var groups = hand.Cards.GroupBy(x => x.Face);
            return groups.Count(x => x.Count() == 2) == 1 && !IsFullHouse(hand);
        }

        public bool IsHighCard(IHand hand)
        {
            if (!IsValidHand(hand))
            {
                return false;
            }

            var group = hand.Cards.GroupBy(card => card.Face);
            bool isHighCard = !IsFlush(hand) && !IsStraight(hand) && !IsStraightFlush(hand) && group.Count() == 5;
            return isHighCard;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
