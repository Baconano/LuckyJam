using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]


public class Card
{
    public int id;
    public string cardName;
    public string cardDescription;
    public string cardKind;

    public Card()
    {
        
    }

    public Card(int cardId, string name, string kind, string description)
    {
        id = cardId;
        cardKind = kind;
        cardName = name;
        cardDescription = description;
    }
}