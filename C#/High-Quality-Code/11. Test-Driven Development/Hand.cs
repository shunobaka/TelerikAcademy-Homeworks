using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            if (this.Cards == null)
            {
                throw new ArgumentNullException("The list of cards shouldn't be null.");
            }

            if (this.Cards.Count == 0)
            {
                throw new ArgumentOutOfRangeException("The list of cards shouldn't be empty.");
            }

            StringBuilder result = new StringBuilder();
            result.AppendLine("Cards in hand:");

            foreach (Card card in this.Cards)
            {
                result.AppendLine(card.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
