using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{

    public Card card;

    public TMP_Text nameText;
    public TMP_Text abilityText;
    public TMP_Text typeText;
    public TMP_Text ratingText;

    public Image artWork;

    public TMP_Text powerText;
    public TMP_Text defenseText;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = card.cardName;
        abilityText.text = card.cardAbility;
        typeText.text = card.cardType;
        ratingText.text = card.cardRating;
        artWork.sprite = card.cardArt;
        powerText.text = card.cardPower.ToString();
        defenseText.text = card.cardDefense.ToString();
    }


}
