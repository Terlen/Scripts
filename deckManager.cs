using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class deckManager : MonoBehaviour
{
    string path;
    string json;
    // Start is called before the first frame update
    void Start()
    {
        // Initialize starter deck from card data in json file
        Deck deck = new Deck();
        path = Application.dataPath + "/Data/csvjson.json";
        json = File.ReadAllText (path);
        //Debug.Log(json);
        deck = JsonUtility.FromJson<Deck>("{\"cards\":" + json + "}");
        //Debug.Log(deck.cards[20].title);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

// Define Deck class
[System.Serializable]
public class Deck
{
    public List<card> cards;
}

// Define individual card class
[System.Serializable]
public class card
{
    public string title;
    public string description;
}