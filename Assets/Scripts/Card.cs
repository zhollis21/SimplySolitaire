using UnityEngine;

public class Card : MonoBehaviour
{
    public enum Suit { Clubs, Diamonds, Hearts, Spades };
    public enum Value { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

    public Suit CardSuit;
    public Value CardValue;
    public bool IsFaceDown = true;
    public Sprite ClubsSprite;
    public Sprite DiamondsSprite;
    public Sprite HeartsSprite;
    public Sprite SpadesSprite;
    public Sprite BackSprite;

    private SpriteRenderer cardRenderer;

    // Start is called before the first frame update
    void Start()
    {
        cardRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsFaceDown)
        {
            cardRenderer.sprite = BackSprite;
        }
        else if (CardSuit == Suit.Clubs)
        {
            cardRenderer.sprite = ClubsSprite;
        }
        else if (CardSuit == Suit.Diamonds)
        {
            cardRenderer.sprite = DiamondsSprite;
        }
        else if (CardSuit == Suit.Hearts)
        {
            cardRenderer.sprite = HeartsSprite;
        }
        else if (CardSuit == Suit.Spades)
        {
            cardRenderer.sprite = SpadesSprite;
        }
    }
}