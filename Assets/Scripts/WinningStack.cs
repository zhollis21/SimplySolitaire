using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WinningStack : CardStack
{
    public bool IsCompleted()
    {
        return false;
    }

    public bool CanDrop(Card cardToDrop)
    {
        if (cards.Count < 1 && cardToDrop.CardValue == Card.Value.Ace)
        {
            return true;
        }
        var blah = cards.Last();
        if (blah.CardSuit != cardToDrop.CardSuit)
        {
            return false;
        }
        //ToDo do value comparison
        return true;
    }

    public void OnDrop(Card cardToDrop)
    {
        if (CanDrop(cardToDrop))
        {
            //do stuff

        }
    }
}
