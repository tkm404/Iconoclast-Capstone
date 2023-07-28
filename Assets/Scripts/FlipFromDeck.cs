using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;

public class FlipFromDeck : MonoBehaviour
{
    public GameObject Player1BoutZone;
    public GameObject Player2BoutZone;
    public GameObject Player1Yard;
    public GameObject Player2Yard;

    public GameObject p1DeckCountDisplay;
    public GameObject p2DeckCountDisplay;

    public List<GameObject> Library = new List<GameObject>();
    // public List<GameObject> CardsInYard1 = new List<GameObject>();
    // public List<GameObject> CardsInYard2 = new List<GameObject>();

    public GameObject myCard;
    public GameObject yourCard;

    public Deck p1Deck;
    public Deck p2Deck;

    public List<Deck> AvailableDecks = new List<Deck>();


    public void Awake()
    {
        Deck ranDeck = ScriptableObject.CreateInstance<Deck>();
        Deck cardRef2 = AvailableDecks[Random.Range(0, AvailableDecks.Count)];
        List<Card> cardstoAdd2 = cardRef2.cardsInDeck;
        foreach (var card in cardstoAdd2)
        {
            ranDeck.cardsInDeck.Add(card);
        }
        p2Deck = ranDeck;
        GameObject p2Counter = p2DeckCountDisplay.transform.GetChild(0).gameObject;
        TMP_Text p2CounterText = p2Counter.GetComponent<TMP_Text>();
        p2CounterText.text = p2Deck.cardsInDeck.Count.ToString();
        
        if (GameManager.instance.currentLeader.deckLeader.name == "Amephyst")
        {   
            Deck useDeck = ScriptableObject.CreateInstance<Deck>();
            Deck cardRef = AvailableDecks.Find(d => d.name == "DeckRockPaper");
            List<Card> cardsToAdd = cardRef.cardsInDeck;
            foreach (var card in cardsToAdd)
            {
                useDeck.cardsInDeck.Add(card);
            }
            p1Deck = useDeck;

        } else if (GameManager.instance.currentLeader.deckLeader.name == "Scissorberus")
        {
            Deck useDeck = ScriptableObject.CreateInstance<Deck>();
            Deck cardRef = AvailableDecks.Find(d => d.name == "DeckScissorsRock");
            List<Card> cardsToAdd = cardRef.cardsInDeck;
            foreach (var card in cardsToAdd)
            {
                useDeck.cardsInDeck.Add(card);
            }
            p1Deck = useDeck;

        } else if (GameManager.instance.currentLeader.deckLeader.name == "PapierMachette")
        {
            Deck useDeck = ScriptableObject.CreateInstance<Deck>();
            Deck cardRef = AvailableDecks.Find(d => d.name == "DeckPaperScissors");  
            List<Card> cardsToAdd = cardRef.cardsInDeck;
            foreach (var card in cardsToAdd)
            {
                useDeck.cardsInDeck.Add(card);
            }        
            p1Deck = useDeck;
        }        
    }

    // Start is called before the first frame update
    void Start()
    {
        Player1BoutZone = GameObject.Find("Player1BoutZone");
        Player2BoutZone = GameObject.Find("Player2BoutZone");
        Player1Yard = GameObject.Find("Player1Yard");
        Player2Yard = GameObject.Find("Player2Yard");
    }

    public void onClick()
    {       
        if (p1Deck.cardsInDeck.Count == 0 || p2Deck.cardsInDeck.Count == 0)
            {
                Debug.Log("Round Over!");
                return;
            }

        Card drawnCard1 = p1Deck.cardsInDeck[Random.Range(0, p1Deck.cardsInDeck.Count)];
        Card drawnCard2 = p2Deck.cardsInDeck[Random.Range(0, p2Deck.cardsInDeck.Count)];

        for (int i = 0; i < Library.Count; i++) 
        {
            if (drawnCard1.cardName == Library[i].name)
            {   
                GameObject myCard = Library[i];  
                p1Deck.cardsInDeck.Remove(drawnCard1);
                Debug.Log(p1Deck.cardsInDeck.Count);



                if (Player1BoutZone.transform.childCount != 0)
                { 
                    for (int k = 0; k < Player1BoutZone.transform.childCount; k++)
                    {
                        GameObject cardToDiscard = Player1BoutZone.transform.GetChild(k).gameObject;
                        // CardsInYard1.Add(cardToDiscard);
                        GameObject yardCard1 = Instantiate(cardToDiscard, new Vector2(0,0), Quaternion.identity);
                        yardCard1.transform.SetParent(Player1Yard.transform, false);                    
                    }      
                }
                
                GameObject topCard = Instantiate(myCard, new Vector2(0,0), Quaternion.identity);
                topCard.transform.SetParent(Player1BoutZone.transform, false);
                break;
            }
            
        }
        for (int j = 0; j < Library.Count; j++)
        {
            if (drawnCard2.cardName == Library[j].name)
            {
                GameObject yourCard = Library[j];
                p2Deck.cardsInDeck.Remove(drawnCard2);
                Debug.Log(p2Deck.cardsInDeck.Count);
                
                if (Player2BoutZone.transform.childCount != 0)
                {
                    for (int m = 0; m < Player2BoutZone.transform.childCount; m++)
                    {
                        GameObject cardToDiscard2 = Player2BoutZone.transform.GetChild(m).gameObject;
                        // CardsInYard2.Add(cardToDiscard2);
                        GameObject yardCard2 = Instantiate(cardToDiscard2, new Vector2(0,0), Quaternion.identity);
                        yardCard2.transform.SetParent(Player2Yard.transform, false);
                    }
                }

                GameObject enemCard = Instantiate(yourCard, new Vector2(0,0), Quaternion.identity);
                enemCard.transform.SetParent(Player2BoutZone.transform, false);
                break;
            }    
                    
        }
    }
}

