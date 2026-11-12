using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DisplayCard : MonoBehaviour
{
    public Card card;
    public int displayId;

    public int id;
    public string cardName;
    public string cardDescription;

    public TextMeshProUGUI cardNameText;
    public TextMeshProUGUI cardDescriptionText;
    public Image cardImage;

    public bool CardBackside;
    public static bool StaticHardBack;

    public GameObject Hand;
    public int NumberofCardsInDeck;

    void Start()
    {
        // Ensure the database has the requested index before fetching
        if (CardDatabase.cardList.Count > displayId)
        {
            // Fixed case: NumberofCardsInDeck (capital N)
            NumberofCardsInDeck = PlayerDeck.deckSize;
            card = CardDatabase.cardList[displayId];

            id = card.id;
            cardName = card.cardName;
            cardDescription = card.cardDescription;

            // Update the UI elements once on start
            if (cardNameText != null) cardNameText.text = cardName;
            if (cardDescriptionText != null) cardDescriptionText.text = cardDescription;
        }
        else
        {
            Debug.LogError("DisplayId " + displayId + " is out of range for CardDatabase!");
        }
    }

    void Update()
    {
        Hand = GameObject.Find("Hand");

        if (Hand != null)
        {
            // Check if parented to the hand properly
            if (this.transform.parent == Hand.transform)
            {
                // Fixed case: CardBackside (capital C and B)
                CardBackside = false;
            }
        }

        // If this card is a newly instantiated clone taking from the deck
        if (this.tag == "Clone")
        {
            // Make sure PlayerDeck has a staticDeck array or list configured
            // displayId = PlayerDeck.staticDeck[NumberofCardsInDeck - 1]; // Uncomment if staticDeck stores IDs
            
            NumberofCardsInDeck--;
            PlayerDeck.deckSize -= 1;
            CardBackside = false;
            this.tag = "Untagged";
        }
    }
}