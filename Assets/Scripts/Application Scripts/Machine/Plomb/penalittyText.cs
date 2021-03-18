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
    public GameObject cryptex;

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
        canvasPlomb.SetActive(false);
        canvasCryptex.SetActive(false);
        canvasMain.SetActive(true);
        cryptex.SetActive(false);

    }
}
