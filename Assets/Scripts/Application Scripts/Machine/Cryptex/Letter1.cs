using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letter1 : MonoBehaviour
{
    public GameObject letter;
    public SpriteRenderer s;
    LetterList letterList;
    public int indexLetter = 0;
    // Start is called before the first frame update
    void Start()
    {
        letterList = GameObject.Find("List Lettre").GetComponent<LetterList>();
        s = letter.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(indexLetter == -1)
        {
            indexLetter = 7;
        }
        if(indexLetter == 8)
        {
            indexLetter = 0;
        }
        ShowLetter();
    }

    public void AddIndex()
    {
        indexLetter ++;
    }
    public void RemoveIndex()
    {
        indexLetter --;
    }

    public void ShowLetter()
    {
        s.sprite = letterList.LettersList[indexLetter].sprite;
    }
}
