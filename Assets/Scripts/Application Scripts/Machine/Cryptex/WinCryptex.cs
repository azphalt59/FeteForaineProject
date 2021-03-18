using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCryptex : MonoBehaviour
{
    LetterList letterList;
    Timer timer;
    Letter1 letter1;
    Letter2 letter2;
    Letter3 letter3;
    Letter4 letter4;
    Letter5 letter5;

    [Header("Les trucs à mettre")]
    public int L1;
    public int L2;
    public int L3;
    public int L4;
    public int L5;
    
    [Header("Cases du cryptex")]
    public SpriteRenderer Case1;
    public SpriteRenderer Case2;
    public SpriteRenderer Case3;
    public SpriteRenderer Case4;
    public SpriteRenderer Case5;

    GameObject gm;
    

    public GameObject canvasMain;
    public GameObject winText;
    public GameObject wrongText;
    // Start is called before the first frame update
    void Start()
    {
        letterList = GameObject.Find("List Lettre").GetComponent<LetterList>();
        gm = GameObject.Find("CryptexManager");
        letter1 = gm.GetComponent<Letter1>();
        letter2 = gm.GetComponent<Letter2>();
        letter3 = gm.GetComponent<Letter3>();
        letter4 = gm.GetComponent<Letter4>();
        letter5 = gm.GetComponent<Letter5>();
        timer = GameObject.Find("AppliManager").GetComponent<Timer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        L1 = letter1.indexLetter;
        L2 = letter2.indexLetter;
        L3 = letter3.indexLetter;
        L4 = letter4.indexLetter;
        L5 = letter5.indexLetter;
    }

    public IEnumerator BackToMainCanvas()
    {
        winText.SetActive(true);
        yield return new WaitForSeconds(5f);
        winText.SetActive(false);
        canvasMain.SetActive(true);
    }
    public IEnumerator DisplayWrongCombination()
    {
        wrongText.SetActive(true);
        yield return new WaitForSeconds(3.5f);
        wrongText.SetActive(false);
    }

    public void ConfirmCode()
    {
        if(L1 == 2 && 
          L2 == 11 &&
          L3 == 14 &&
          L4 == 22 &&
          L5 == 13
        ) 
        {
           StartCoroutine(BackToMainCanvas());
        }
        else
        {
            timer.Penality();
            StartCoroutine(DisplayWrongCombination());
        }
    }
}
