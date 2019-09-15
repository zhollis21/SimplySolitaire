using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{  
    private CardStack undealtCards = new CardStack();
    private CardStack dealtCards = new CardStack();
    private Vector2 dealtCardPositon;

    // Start is called before the first frame update
    void Start()
    {
        dealtCardPositon = new Vector2(transform.position.x + 2, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        Card clickedCard = undealtCards.Pop();

        if (clickedCard != null)
        {
            clickedCard.transform.position = dealtCardPositon;
            clickedCard.IsFaceDown = false;

            dealtCards.Push(clickedCard);
        }
        else
        {
            Card dealtCard = dealtCards.Pop();

            while(dealtCard != null)
            {
                dealtCard.transform.position = this.transform.position;
                dealtCard.IsFaceDown = true;

                undealtCards.Push(dealtCard);

                dealtCard = dealtCards.Pop();
            }
        }        
    }

    public void InitializeDeck(List<Card> cards)
    {
        undealtCards.ClearStack();
        dealtCards.ClearStack();

        foreach (Card card in cards)
        {
            card.transform.position = this.transform.position;
        }

        undealtCards.PushRange(cards);
    }
}
