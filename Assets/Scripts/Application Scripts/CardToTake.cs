using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardToTake : MonoBehaviour
{
    Text cardsToTakeText;
    public List<int> CardsToTake = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        cardsToTakeText = this.gameObject.GetComponent<Text>();
        cardsToTakeText.text = "Prenez la carte : ";
    }

    // Update is called once per frame
    void Update()
    {
        if(CardsToTake.Count == 1) 
        { cardsToTakeText.text = "Prenez la carte : " + ListToText(CardsToTake);} 
        else 
        {cardsToTakeText.text = "Prenez les cartes : " + "\n" + ListToText(CardsToTake);}
    }

    public string ListToText(List<int> list)
    {
        string result = "";
        foreach(var listMember in list)
        {
            result += listMember.ToString() + "    ";
        }
        return result;
    }
}
