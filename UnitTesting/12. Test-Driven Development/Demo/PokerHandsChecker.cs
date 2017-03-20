using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            else
            {
                for (int i = 0; i < hand.Cards.Count; i++)
                {
                    for (int j = i + 1; j < hand.Cards.Count; j++)
                    {
                        if (hand.Cards[i].Face == hand.Cards[j].Face && hand.Cards[i].Suit == hand.Cards[j].Suit)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            int counter = 1;
            IList<ICard> sortedList = hand.Cards.OrderBy(x => x.Face).ToList();
            for (int i = 0; i < sortedList.Count -1; i++)
            {
                if (sortedList[i].Face == sortedList[i+1].Face)
                {
                    counter++;
                    if (counter == 4)
                    {
                        return true;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            if (counter == 4)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            for (int i = 0; i < hand.Cards.Count-1; i++)
            {
                if (hand.Cards[i].Suit != hand.Cards[i+1].Suit)
                {
                    return false;
                }
            }
            return true;

        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
