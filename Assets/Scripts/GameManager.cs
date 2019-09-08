using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Card2Prefab;
    public GameObject Card3Prefab;
    public GameObject Card4Prefab;
    public GameObject Card5Prefab;
    public GameObject Card6Prefab;
    public GameObject Card7Prefab;
    public GameObject Card8Prefab;
    public GameObject Card9Prefab;
    public GameObject Card10Prefab;
    public GameObject CardJPrefab;
    public GameObject CardQPrefab;
    public GameObject CardKPrefab;
    public GameObject CardAPrefab;

    private List<Card> cards = new List<Card>();

    // Start is called before the first frame update
    void Start()
    {
        CreateCards();
        Deal();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void CreateCards()
    {
        // Creates 4 suits for each card value
        for(int suit = 0; suit < 4; suit++)
        {
            GameObject card2 = Instantiate(Card2Prefab);
            Card card2Script = card2.GetComponent<Card>();
            card2Script.CardSuit = (Card.Suit)suit;
            cards.Add(card2Script);

            GameObject card3 = Instantiate(Card3Prefab);
            Card card3Script = card3.GetComponent<Card>();
            card3Script.CardSuit = (Card.Suit)suit;
            cards.Add(card3Script);

            GameObject card4 = Instantiate(Card4Prefab);
            Card card4Script = card4.GetComponent<Card>();
            card4Script.CardSuit = (Card.Suit)suit;
            cards.Add(card4Script);

            GameObject card5 = Instantiate(Card5Prefab);
            Card card5Script = card5.GetComponent<Card>();
            card5Script.CardSuit = (Card.Suit)suit;
            cards.Add(card5Script);

            GameObject card6 = Instantiate(Card6Prefab);
            Card card6Script = card6.GetComponent<Card>();
            card6Script.CardSuit = (Card.Suit)suit;
            cards.Add(card6Script);

            GameObject card7 = Instantiate(Card7Prefab);
            Card card7Script = card7.GetComponent<Card>();
            card7Script.CardSuit = (Card.Suit)suit;
            cards.Add(card7Script);

            GameObject card8 = Instantiate(Card8Prefab);
            Card card8Script = card8.GetComponent<Card>();
            card8Script.CardSuit = (Card.Suit)suit;
            cards.Add(card8Script);

            GameObject card9 = Instantiate(Card9Prefab);
            Card card9Script = card9.GetComponent<Card>();
            card9Script.CardSuit = (Card.Suit)suit;
            cards.Add(card9Script);

            GameObject card10 = Instantiate(Card10Prefab);
            Card card10Script = card10.GetComponent<Card>();
            card10Script.CardSuit = (Card.Suit)suit;
            cards.Add(card10Script);

            GameObject cardJ = Instantiate(CardJPrefab);
            Card cardJScript = cardJ.GetComponent<Card>();
            cardJScript.CardSuit = (Card.Suit)suit;
            cards.Add(cardJScript);

            GameObject cardQ = Instantiate(CardQPrefab);
            Card cardQScript = cardQ.GetComponent<Card>();
            cardQScript.CardSuit = (Card.Suit)suit;
            cards.Add(cardQScript);

            GameObject cardK = Instantiate(CardKPrefab);
            Card cardKScript = cardK.GetComponent<Card>();
            cardKScript.CardSuit = (Card.Suit)suit;
            cards.Add(cardKScript);

            GameObject cardA = Instantiate(CardAPrefab);
            Card cardAScript = cardA.GetComponent<Card>();
            cardAScript.CardSuit = (Card.Suit)suit;
            cards.Add(cardAScript);
        }
    }

    public void Shuffle()
    {
        // ToDo
    }

    public void Deal()
    {
        Shuffle();

        // ToDo
    }
}
