using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class handManagement : MonoBehaviour
{
    public GameObject cardPrefab;
    public GameObject hand;
    public GameObject Deck;
    //public Deck deck;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void drawCard(int numCards){
        Debug.Log("This is the drawCard method being called");
        
        Deck deck = Deck.GetComponent<deckManager>().deck;
        Debug.Log(deck.cards[0].title);
        deckDraw pull = Deck.GetComponent<cardGenerator>().randomDraw(numCards, deck);
        Debug.Log("First card title: " + pull.cards[0].title);
        
        //GameObject[] hand = new GameObject[10];
        Vector2 leftOffset = new Vector2(2f,0);
        Vector2 rightOffset = new Vector2(2f,0);
        Vector2 origin = new Vector2(0,-3.72f);
        //hand[0] = Instantiate(cardPrefab, new Vector2(0, -3.72f), Quaternion.identity);
        GameObject card = Instantiate(cardPrefab, origin, Quaternion.identity);
        card.name = "card0";
        card.transform.parent = gameObject.transform;
        List<Text> cardText = new List<Text>();
        card.transform.GetComponentsInChildren<Text>(cardText);
        //cardText[0].text = "This is the origin";
        cardText[0].text = pull.cards[0].title;
        cardText[1].text = pull.cards[0].description;
        //hand[0].transform.parent = gameObject.transform;
        
        for (int i = 1; i < numCards; i++){
            if (i%2 == 0){
                card = Instantiate(cardPrefab, origin + rightOffset*(i/2), Quaternion.identity);
                card.name = "card"+i;
                card.transform.parent = gameObject.transform;
                //rightOffset += new Vector2(2f,0);
                card.transform.GetComponentsInChildren<Text>(cardText);
                //cardText[0].text = "This is the origin";
                cardText[0].text = pull.cards[i].title;
                cardText[1].text = pull.cards[i].description;
            } 
            else {
                /* Debug.Log(i);
                Debug.Log(Mathf.Ceil(i/2f));
                Debug.Log(origin - leftOffset*(Mathf.Ceil(i/2f))); */
                card = Instantiate(cardPrefab, origin - leftOffset*(Mathf.Ceil(i/2f)), Quaternion.identity);
                card.name = "card"+i;
                card.transform.parent = gameObject.transform;
                //leftOffset += new Vector2(2f,0);
                card.transform.GetComponentsInChildren<Text>(cardText);
                //cardText[0].text = "This is the origin";
                cardText[0].text = pull.cards[i].title;
                cardText[1].text = pull.cards[i].description;
            }
            
            //Debug.Log(card.transform.position);
            //Debug.Log(card.transform.rect.width);
        }

        //return hand;
    }
}



