using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardGenerator : MonoBehaviour
{
    

    //public List<card> drawnCards = new List<card>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public deckDraw randomDraw(int drawSize, Deck deck){
        
        //Debug.Log(deck.cards[0].title);
        /* for (int x = 0; x < deck.cards.Count; x++){
            Debug.Log(deck.cards[x]);
        } */
        deckDraw drawnCards = new deckDraw();
        drawnCards.cards = new List<card>();

        // select random cards from deck and add them to drawnCards List
        for (int x = 0; x < drawSize; x++){
            int cardNum = Random.Range(0,deck.cards.Count-1);
            /* Debug.Log(cardNum);
            Debug.Log(drawnCards.cards.Count);
            Debug.Log(deck.cards[cardNum]); */
            drawnCards.cards.Add(deck.cards[cardNum]);
            deck.cards.RemoveAt(cardNum);
        }
        return drawnCards;

        /* for (int x = 0; x < drawnCards.cards.Count; x++){
            Debug.Log(drawnCards.cards[x]);
        } */

    }

}




public class deckDraw
{
    public List<card> cards;
}