using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PiscineManager : MonoBehaviour
{
    [SerializeField]
    private List<Text> LettersGO = new List<Text>();
    [SerializeField]
    private List<string> Letters;
    [SerializeField]
    private Text Indice;

    [SerializeField]
    private string IndiceSiMauvaixOrdre;
    
    [SerializeField]
    private string IndiceSiBonOrdre;

    // Start is called before the first frame update
    void Start()
    {
        Letters.Shuffle();
        foreach(Text letter in LettersGO){
            letter.gameObject.SetActive(false);
            letter.text = Letters[LettersGO.IndexOf(letter)];
        }
        string totalLetters = null;
            foreach(string Letter in Letters){
                totalLetters += Letter;
            }
        if (totalLetters == "SECRET"){
            Indice.text = totalLetters + IndiceSiBonOrdre;
        }
        else {
            Indice.text = totalLetters + IndiceSiMauvaixOrdre;
        }
    }

    public void ShowLetter(int index){
        LettersGO[index].gameObject.SetActive(true);
        bool AllLettersVisible = true;
        foreach (Text Letter in LettersGO)
        {
            if (!Letter.gameObject.activeSelf){
                AllLettersVisible = false;
                break;
            }
        }
        Indice.gameObject.SetActive(AllLettersVisible);
    }

}
