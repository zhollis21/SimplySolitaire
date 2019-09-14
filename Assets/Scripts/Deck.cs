using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    /* Need a additional list that shows the very last card.     
     * If the player clicks on the original deck, the last card moves to the additional deck
     * If the player clicks on the additional deck and drags and drops the card somewhere else, that card gets removed from the additional deck
     * Once we have all the cards from the original list of cards into the additional list of cards, 
       we need to merge the additional list into the original list */

    private CardStack undealtCards = new CardStack();
    private CardStack dealtCards = new CardStack();   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDeckClick()
    {
        Card clickedCard = undealtCards.Pop();

        dealtCards.Push(clickedCard);
    }

    public void InitializeDeck(List<Card> cards)
    {
        undealtCards.ClearStack();
        dealtCards.ClearStack();

        undealtCards.PushRange(cards);
    }    
}
