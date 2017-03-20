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
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Cards.Count-1; i++)
            {
                sb.AppendFormat("{0}, ", Cards[i].ToString());
            }
            sb.Append(Cards[Cards.Count - 1]);

            return sb.ToString();
        }
    }
}
