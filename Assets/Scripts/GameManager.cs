﻿using System.Collections.Generic;
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
    public Deck CardDeck;

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

    private void CreateCard(GameObject cardPrefab, Card.Suit suit)
    {
        GameObject card = Instantiate(cardPrefab);
        Card cardScript = card.GetComponent<Card>();
        cardScript.CardSuit = suit;
        cards.Add(cardScript);
    }

    private void CreateCards()
    {
        // Creates 4 suits for each card value
        for (int suitNumber = 0; suitNumber < 4; suitNumber++)
        {
            var suit = (Card.Suit)suitNumber;

            CreateCard(Card2Prefab, suit);
            CreateCard(Card3Prefab, suit);
            CreateCard(Card4Prefab, suit);
            CreateCard(Card5Prefab, suit);
            CreateCard(Card6Prefab, suit);
            CreateCard(Card7Prefab, suit);
            CreateCard(Card8Prefab, suit);
            CreateCard(Card9Prefab, suit);
            CreateCard(Card10Prefab, suit);
            CreateCard(CardJPrefab, suit);
            CreateCard(CardQPrefab, suit);
            CreateCard(CardKPrefab, suit);
            CreateCard(CardAPrefab, suit);
        }
    }

    public void Shuffle()
    {
        // Loops through the list 4 times, randomly removing a card and placing it at the end
        int numCards = cards.Count;

        for (int i = 0; i < numCards * 4; i++)
        {
            int randomIndex = Random.Range(0, numCards);
            Card randomCard = cards[randomIndex];
            cards.RemoveAt(randomIndex);
            cards.Add(randomCard);
        }
    }

    public void Deal()
    {
        Shuffle();

        CardDeck.InitializeDeck(cards);
    }
}
