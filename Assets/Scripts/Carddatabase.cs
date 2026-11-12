using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();
    void Awake(){
        // Initalize Card Database, ID , Name, Kind, Description
        cardList.Add(new Card(0,"Pants on Fire", "Response",  "Lier Lier pants on fire!")); // each player has 2 out of deck
        cardList.Add(new Card(1,"Guess", "Guess",  "Guess their number"));
        cardList.Add(new Card(2,"Even Stevens", "Question", "Ask your opponent if their number is even or odd"));
        cardList.Add(new Card(3,"Half Sale", "Question",  "Ask your opponent if their number is greater than or equal to 25"));
        cardList.Add(new Card(4,"Prime Time", "Question",  "Ask your opponent if their number is prime"));
        cardList.Add(new Card(5,"Lucky 7", "Question",  "Ask your opponent if their nuumber contains 7"));
        cardList.Add(new Card(6,"FizzBuzz", "Question",  "Ask your opponent if their number is divisible by 3 or 5"));
        cardList.Add(new Card(7,"Deflect", "Response",  "Opponent Answers their own question")); 
        cardList.Add(new Card(8,"Silent", "Response",  "Don't answer your opponents question, they lose their turn"));
        cardList.Add(new Card(9,"Mirror", "Response",  "both players answer the same question"));
        cardList.Add(new Card(10,"Discard", "Trick",  "Opponent must discard a card of their choice"));
        cardList.Add(new Card(11,"You Lied Didn't You", "Trick",  "Reveals how many lies your opponent has told in the past 5 turns"));
        cardList.Add(new Card(12,"Interrogate", "Trick",  "Pick one past answer; the game reveals if it was a lie"));



    }
}