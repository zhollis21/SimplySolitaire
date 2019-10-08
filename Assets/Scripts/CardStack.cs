using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class CardStack
    {
        protected List<Card> cards = new List<Card>();

        public void Push(Card newCard)
        {
            SpriteRenderer sr = newCard.GetComponent<SpriteRenderer>();
            sr.sortingOrder = cards.Count;

            cards.Add(newCard);
        }

        public void PushRange(List<Card> newCards)
        {
            foreach(Card card in newCards)
            {
                Push(card);
            }
        }

        /// <summary>
        /// Returns and removes the top card from the stack
        /// </summary>
        public Card Pop()
        {
            if (cards.Count < 1)
                return null;

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