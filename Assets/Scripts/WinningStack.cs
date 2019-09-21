using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WinningStack : CardStack
{
    private Card.Value lastCardValue;
    private Card.Suit stackSuit;

    public bool IsCompleted()
    {
        return lastCardValue == Card.Value.King;
    }

    public bool CanDrop(Card cardToDrop)
    {
        if (lastCardValue == Card.Value.King)
        {
            return false;
        }

        if (cards.Count < 1 && cardToDrop.CardValue == Card.Value.Ace)
        {
            return true;
        }

        if (stackSuit == cardToDrop.CardSuit && cardToDrop.CardValue == lastCardValue + 1)
        {
            return true;
        }

        return false;
    }

    public void OnDrop(Card cardToDrop)
    {
        if (CanDrop(cardToDrop))
        {
            cards.Add(cardToDrop);
            lastCardValue = cardToDrop.CardValue;
            stackSuit = cardToDrop.CardSuit;
        }
    }
}