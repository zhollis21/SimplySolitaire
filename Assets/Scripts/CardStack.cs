using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class CardStack
    {
        protected List<Card> cards = new List<Card>();

        public void Push(Card newCard)
        {
            cards.Add(newCard);
        }

        public void PushRange(List<Card> newCards)
        {
            cards.AddRange(newCards);
        }

        public Card Pop()
        {
            Card lastCard = cards.Last();
            cards.Remove(lastCard);

            return lastCard;
        }

        public void ClearStack()
        {
            cards.Clear();
        }
    }
}
