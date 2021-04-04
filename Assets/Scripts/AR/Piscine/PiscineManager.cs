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

    // Start is called before the first frame update
    void Start()
    {
        Letters.Shuffle();
        foreach(Text letter in LettersGO){
            letter.gameObject.SetActive(false);
            letter.text = Letters[LettersGO.IndexOf(letter)];
        }
    }

    public void ShowLetter(int index){
        LettersGO[index].gameObject.SetActive(true);
    }

}
