using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardToDiscard : MonoBehaviour
{
    Text cardsToDiscardText;
    public List<int> CardsToDiscard = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        cardsToDiscardText = this.gameObject.GetComponent<Text>();
        cardsToDiscardText.text = "Défaussez la carte : ";
    }

    // Update is called once per frame
    void Update()
    {
        if (CardsToDiscard.Count == 1)
        { cardsToDiscardText.text = "Défaussez la carte : " + ListToText(CardsToDiscard); }
        else
        { cardsToDiscardText.text = "Défaussez les cartes : " + "\n" + ListToText(CardsToDiscard); }
    }

    public string ListToText(List<int> list)
    {
        string result = "";
        foreach (var listMember in list)
        {
            result += listMember.ToString() + "    ";
        }
        return result;
    }
}
