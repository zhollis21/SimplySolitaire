using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts
{
    public class CardStack : MonoBehaviour
    {
        protected List<Card> cards = new List<Card>();

        /// <summary>
        /// Adds a card on top of the stack
        /// </summary>
        public void Push(Card newCard)
        {
            SpriteRenderer sr = newCard.GetComponent<SpriteRenderer>();
            sr.sortingOrder = cards.Count;

            cards.Add(newCard);
        }

        /// <summary>
        /// Pushes a list of cards in their current order onto the stack
        /// </summary>
        public void PushRange(List<Card> newCards)
        {
            foreach(Card card in newCards)
            {
                Push(card);
            }
        }

        /// <summary>
        /// Removes and returns the top card from the stack
        /// </summary>
        public Card Pop()
        {
            if (cards.Count < 1)
                return null;

            Card lastCard = cards.Last();
            cards.Remove(lastCard);

            return lastCard;
        }

        /// <summary>
        /// Removes all cards from the stack
        /// </summary>
        public void ClearStack()
        {
            cards.Clear();
        }
    }
}