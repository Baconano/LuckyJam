using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public static List<Card> staticDeck = new List<Card>();
    public static int deckSize;

    [Header("UI & Prefabs")]
    public GameObject cardPrefab; // Drag your Card Prefab here in the Inspector

    void Start()
    {
        // Clear the list to ensure a clean slate
        deck.Clear();
        staticDeck.Clear();

        for (int i = 0; i < 30; i++)
        {
            // Random.Range for integers has an exclusive upper bound, 
            // so (1, 13) correctly picks random indices from 1 to 12.
            int randomIndex = Random.Range(1, 13);
            Card selectedCharAt = CardDatabase.cardList[randomIndex];

            // Add to both the instance list and the static list
            deck.Add(selectedCharAt);
            staticDeck.Add(selectedCharAt);
        }

        // Initialize deckSize so DisplayCard can track it
        deckSize = staticDeck.Count;

        // --- DRAW STARTING HAND OF 5 CARDS ---
        StartCoroutine(DrawStartingHandRoutine());
    }

    IEnumerator DrawStartingHandRoutine()
    {
        yield return null; 

        for (int i = 0; i < 5; i++)
        {
            if (cardPrefab != null && staticDeck.Count > 0)
            {
            // 1. Grab the top card from the static deck and remove it from the pool
                Card drawnCard = staticDeck[0];
                staticDeck.RemoveAt(0);
                deckSize = staticDeck.Count; // Update deck size tracker

            // 2. Instantiate the card prefab
                GameObject newCard = Instantiate(cardPrefab);

            // 3. Find the DisplayCard script on the clone and assign its ID dynamically
                DisplayCard display = newCard.GetComponent<DisplayCard>();
                if (display != null)
                {
                    display.displayId = drawnCard.id;
                }
            }
            else
            {
                Debug.LogError("Card Prefab is missing or Deck is empty!");
            }
        }
    }
    
    

    void Update()
    {
        
    }
}