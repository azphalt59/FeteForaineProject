using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenWord : MonoBehaviour
{
    public GameObject canvasHiddenWord;
    public GameObject canvasMain;
    public GameObject hiddenWord;
    public GameObject winText;
    public GameObject wrongText;

    HiddenLetter hidden1;
    HiddenLetter hidden2;
    HiddenLetter hidden3;
    HiddenLetter hidden4;
    HiddenLetter hidden5;
    HiddenLetter hidden6;
    public int C1;
    public int C2;
    public int C3;
    public int C4;
    public int C5;
    public int C6;


    // Start is called before the first frame update
    void Start()
    {
        hidden1 = GameObject.Find("Case1").GetComponent<HiddenLetter>();
        hidden2 = GameObject.Find("Case2").GetComponent<HiddenLetter>();
        hidden3 = GameObject.Find("Case3").GetComponent<HiddenLetter>();
        hidden4 = GameObject.Find("Case4").GetComponent<HiddenLetter>();
        hidden5 = GameObject.Find("Case5").GetComponent<HiddenLetter>();
        hidden6 = GameObject.Find("Case6").GetComponent<HiddenLetter>();
    }

    // Update is called once per frame
    void Update()
    {
        C1 = hidden1.indexletter;
        C2 = hidden2.indexletter;
        C3 = hidden3.indexletter;
        C4 = hidden4.indexletter;
        C5 = hidden5.indexletter;
        C6 = hidden6.indexletter;
    }
    public void OpenCanvasHiddenWord()
    {
        canvasMain.SetActive(false);
        canvasHiddenWord.SetActive(true);
        hiddenWord.SetActive(true);
    }
    public void CloseCanvasHiddenWord()
    {
        canvasHiddenWord.SetActive(false);
        hiddenWord.SetActive(false);
    }
    public void ConfirmCode()
    {
        if(C1 == 18 && C2 == 4 && C3 == 2 && C4 == 17 && C5 == 4 && C6 == 19)
        {
            StartCoroutine(BackToMain());
        } else {StartCoroutine(Wrong());}
    }
    public IEnumerator BackToMain()
    {
        winText.SetActive(true);
        yield return new WaitForSeconds(5f);
        canvasMain.SetActive(true);
        canvasHiddenWord.SetActive(false);
        canvasHiddenWord.SetActive(false);
    }
    public IEnumerator Wrong()
    {
        wrongText.SetActive(true);
        yield return new WaitForSeconds(3f);
        wrongText.SetActive(false);
    }
}
