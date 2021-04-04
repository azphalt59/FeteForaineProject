using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class penalittyText : MonoBehaviour
{
    public GameObject penality;
    public GameObject canvasMain;
    public GameObject canvasPlomb;
    public GameObject canvasCryptex;
    public GameObject canvasToucheCoule;
    public GameObject canvasHiddenWord;
    public GameObject canvasCarabine;
    public GameObject toucheCoule;
    public GameObject cryptex;
    public GameObject hiddenWord;
    public GameObject canvasIndice;
    public GameObject carabine;
    
    public List<Slider> sliders;
    public List<GameObject> fills;
    public Button confirmbutton;
    public List<GameObject> bgFills;

    public void DisplayPenalityText()
    {
        StartCoroutine(ShowPenalityText());
    }
    public IEnumerator ShowPenalityText()
    {
        penality.SetActive(true);
        DisablePlomb();
        yield return new WaitForSeconds(3f);
        
    }
    public void BackToCanvasMain()
    {
        canvasHiddenWord.SetActive(false);
        canvasPlomb.SetActive(false);
        canvasCryptex.SetActive(false);
        canvasToucheCoule.SetActive(false);
        canvasCarabine.SetActive(false);
        canvasMain.SetActive(true);
        carabine.SetActive(false);
        cryptex.SetActive(false);
        hiddenWord.SetActive(false);
        canvasHiddenWord.SetActive(false);
        toucheCoule.SetActive(false);
        canvasIndice.SetActive(false);
    }
    public void DisablePlomb()
    {
        foreach(Slider s in sliders)
        {
            s.interactable = false;
        }
        foreach(GameObject f in fills)
        {
            f.GetComponent<Image>().color = Color.red;
        }
        foreach(GameObject f in bgFills)
        {
            f.GetComponent<Image>().color = Color.red;
        }
        var colors = confirmbutton.GetComponent<Button>().colors;
        colors.normalColor = Color.red;
        colors.disabledColor = Color.red;
        confirmbutton.GetComponent<Button>().colors = colors;
        confirmbutton.interactable = false;
    }
}
