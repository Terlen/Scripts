/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class deckInit : MonoBehaviour
{
    string path;
    string json;
    // Start is called before the first frame update
    void Start()
    {
        Deck deck = new Deck();
        path = Application.dataPath + "/Data/csvjson.json";
        json = File.ReadAllText (path);
        //Debug.Log(json);
        deck = JsonUtility.FromJson<Deck>("{\"cards\":" + json + "}");
        //Debug.Log(deck);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

}

[System.Serializable]
public class Deck
{
    public List<card> cards;
} */