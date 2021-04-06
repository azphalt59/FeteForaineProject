using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoTamponeuseManager : MonoBehaviour
{
    public List<Button> LesZautosTamponantes;
    public List<Image> LesLed;
    int RedLed = 0;
    public GameObject wintext;

    penalittyText backTocanvasMain;
    // Start is called before the first frame update
    
    void Start() 
    {
        backTocanvasMain = GameObject.Find("AppliManager").GetComponent<penalittyText>();
    }
    public void ChangeColorLed()
    {
        LesLed[0].color = Color.red;
        LesLed.RemoveAt(0);
        RedLed ++;
    }
    public void Win()
    {
        StartCoroutine(WinAutoTamponeuse());
    }

    public IEnumerator WinAutoTamponeuse()
    {
        yield return new WaitForSeconds(3f);
        wintext.SetActive(true);
        yield return new WaitForSeconds(4f);
       
        backTocanvasMain.BackToCanvasMain();
    }
    void Update() 
    {
        if(RedLed == 4)
        {
            Win();
        }
    }

}
