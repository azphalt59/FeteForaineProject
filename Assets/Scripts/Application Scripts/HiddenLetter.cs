using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenLetter : MonoBehaviour
{
    ListeDeLettreClassique listeDeLettreClassique;
    public int indexletter = 0;
    public GameObject letter;
    // Start is called before the first frame update
    void Start()
    {
        listeDeLettreClassique = GameObject.Find("List").GetComponent<ListeDeLettreClassique>();

    }

    // Update is called once per frame
    void Update()
    {
        if(indexletter == -1)
        {
            indexletter = 26;
        }
        if(indexletter == 27)
        {
            indexletter = 0;
        }
        ShowLetter();
    }
    public void ShowLetter()
    {
        letter.GetComponent<SpriteRenderer>().sprite = listeDeLettreClassique.Lettre[indexletter].GetComponent<SpriteRenderer>().sprite;
    }
    public void AddIndex()
    {
        indexletter ++;
    }
    public void RemoveIndex()
    {
        indexletter --;
    }
}

