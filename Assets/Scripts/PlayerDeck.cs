using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();

    void Start()
    {
        // Clear the list to ensure a clean slate
        deck.Clear();

        for (int i = 0; i < 30; i++)
        {
            // Random.Range for integers has an exclusive upper bound, 
            // so (1, 12) correctly picks random indices from 1 to 11.
            int randomIndex = Random.Range(1, 13);

            // Add the random card from the database into your deck list
            deck.Add(CardDatabase.cardList[randomIndex]);
        }
    }

    void Update()
    {
        // Update is now correctly placed outside of Start()
    }
}