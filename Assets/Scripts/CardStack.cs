using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class CardStack
    {
        public List<Card> Cards = new List<Card>();

        public void Push(Card newCard)
        {
            Cards.Add(newCard);
        }

        public Card Pop()
        {
            Card lastCard = Cards.Last();
            Cards.Remove(lastCard);

            return lastCard;
        }
    }
}
