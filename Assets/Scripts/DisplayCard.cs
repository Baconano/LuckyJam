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

    public bool CardBackside;
    public static bool StaticHardBack;
    void Start()
    {
        // Ensure the database has the requested index before fetching
        if (CardDatabase.cardList.Count > displayId)
        {
            card = CardDatabase.cardList[displayId];

            id = card.id;
            cardName = card.cardName;
            cardDescription = card.cardDescription;

            // Update the UI elements once on start
            cardNameText.text = cardName;
            cardDescriptionText.text = cardDescription;
        }
        else
        {
            Debug.LogError("DisplayId " + displayId + " is out of range for CardDatabase!");
        }
    }
    void Update()
    {
        // Update the UI elements every frame (if needed)
        StaticHardBack = CardBackside;
    }
}