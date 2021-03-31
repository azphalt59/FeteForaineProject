using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tips : MonoBehaviour
{
    public Text tipsText;
    string tipsTextValue = "";
    public GameObject canvasIndice;
    public GameObject canvasMain;

    public GameObject indiceDisplayer;
    public Text indiceDisplayerText;
    public Text indiceDisplayerText2;
    public Text indiceDisplayerText3;
    public Text indiceDisplayerCardNumber;
    
    public List<Indice> allTips;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayTips();
        if(tipsTextValue.Length > 3)
        {
            tipsTextValue = "";
        }
    }
    public void DisplayTips()
    {
        tipsText.text = tipsTextValue;
    }
    public void ActiveCanvasTips()
    {
        canvasIndice.SetActive(true);
        canvasMain.SetActive(false);
    }
    public void CloseCanvasTips()
    {
        canvasIndice.SetActive(false);
        canvasMain.SetActive(true);
    }
    public void AddNumber(string number)
    {
        tipsTextValue += number;
    }
    public void ResetNumber()
    {
        tipsTextValue = "";
    }
    public void ConfirmCode()
    {
        indiceDisplayer.SetActive(true);
        for(int i=0; i < allTips.Count; i++)
        {
            if(tipsTextValue == allTips[i].index.ToString())
            {
                indiceDisplayerCardNumber.text = allTips[i].index.ToString();
                indiceDisplayerText.text = allTips[i].st;
                allTips[i].count ++;
                if(allTips[i].count >= 2)
                {
                indiceDisplayerText2.text = allTips[i].st2;
                } else {indiceDisplayerText2.text = "";}
                if(allTips[i].count >= 3)
                {
                indiceDisplayerText3.text = allTips[i].st3;
                } else {indiceDisplayerText3.text = "";}
            }
            /*else
            {
                indiceDisplayerCardNumber.text = "Mauvais numéro";
                indiceDisplayerText.text = "Il n'y a pas d'indice pour cette carte ou cette carte n'existe pas";
                indiceDisplayerText2.text = "";
                indiceDisplayerText3.text = "";
            }*/
           
            
            
        }
        StartCoroutine(Displayer());     
    }
    public IEnumerator Displayer()
    {
        yield return new WaitForSeconds(5f);
        indiceDisplayerText.text = "";
        indiceDisplayerText2.text = "";
        indiceDisplayerText3.text = "";
        indiceDisplayerCardNumber.text = "";
        indiceDisplayer.SetActive(false);
    }
}
