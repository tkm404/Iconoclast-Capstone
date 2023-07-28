using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DeckDisplay : MonoBehaviour
{

    public Deck deck;
    public TMP_Text cardsRemaining;

    public List<Card> deckCards = new List<Card>();

    // Start is called before the first frame update
    void Start()
    {
        cardsRemaining.text = deck.cardsInDeck.Count.ToString();

        foreach (var card in deck.cardsInDeck)
        {
            deckCards.Add(card);
        }
    }

    void Update(){
        cardsRemaining.text = deck.cardsInDeck.Count.ToString();
    }

}
