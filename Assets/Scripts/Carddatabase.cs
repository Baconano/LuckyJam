using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();
    void Awake(){
        cardList.Add(new Card(0,"Goon",  "Goon"));
        cardList.Add(new Card(1,"Guess",  "Guess their number"));
        cardList.Add(new Card(2,"Question", "Ask a Question"));
        cardList.Add(new Card(3,"Abilities",  "playuer ability"));


    }
}