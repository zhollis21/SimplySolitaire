using Assets.Scripts;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{  
    public CardStack undealtCards;
    public CardStack dealtCards;
    private Vector2 dealtCardPositon;

    // Start is called before the first frame update
    void Start()
    {
        dealtCardPositon = new Vector2(transform.position.x + 1.5f, transform.position.y); 
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
