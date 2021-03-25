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
    public GameObject toucheCoule;
    public GameObject cryptex;
    public GameObject hiddenWord;

    public void DisplayPenalityText()
    {
        StartCoroutine(ShowPenalityText());
    }
    public IEnumerator ShowPenalityText()
    {
        penality.SetActive(true);
        yield return new WaitForSeconds(3f);
        penality.SetActive(false);
    }
    public void BackToCanvasMain()
    {
        canvasHiddenWord.SetActive(false);
        canvasPlomb.SetActive(false);
        canvasCryptex.SetActive(false);
        canvasToucheCoule.SetActive(false);
        canvasMain.SetActive(true);
        cryptex.SetActive(false);
        hiddenWord.SetActive(false);
        canvasHiddenWord.SetActive(false);
        toucheCoule.SetActive(false);


    }
}
