using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
  public string cardName;
  public string cardAbility;
  public string cardType;
  public string cardRating;

  public Sprite cardArt;

  public int cardPower;
  public int cardDefense;
}
