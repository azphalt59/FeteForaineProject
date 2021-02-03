using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Code : MonoBehaviour
{
    public Text codeText;
    string codeTextValue = "";
    public GameObject canvasCode;

    Timer timer;


    [Header("Code Cards GameObjects")]
    public GameObject wrongCode;
    public GameObject codeCarnival;
    public GameObject codeHautedHouse;
    public GameObject codeRandom1;
    public GameObject codeRandom2;

   
    public List<string> RightCodes = new List<string>();
    
    void Update()
    {
        DisplayCode();
        if (codeTextValue.Length > 4)
        {
            codeTextValue = "";
        }
    }

    public void ActiveCanvasCode()
    {
        canvasCode.SetActive(true);
    }
    public void CloseCanvasCode()
    {
        canvasCode.SetActive(false);
    }

    public void DisplayCode()
    {
        codeText.text = codeTextValue;
    }

    public void AddNumber(string number)
    {
        codeTextValue += number;
        Debug.Log(number);
    }

    public void ResetNumber()
    {
        codeTextValue = "";
    }

    public void ConfirmCode()
    {
        if (RightCodes.Contains(codeTextValue))
        {
            if(codeTextValue == RightCodes[0]) //CODE 1983 SORTIE DE LE FETE FORAINE
            {
                codeCarnival.SetActive(true);
                Debug.Log("Vous avez le bon code, prenez la carte WIN");
            }
            if(codeTextValue == RightCodes[1]) //Code 1111 SORTIE DE LA MAISON HANTEE
            {
                codeHautedHouse.SetActive(true);
                Debug.Log("Vous avez le bon code, prenez la carte fête foraine ");
            }
            if (codeTextValue == RightCodes[2]) // CODE 9999 CODE RANDOM 1
            {
                codeRandom1.SetActive(true);
                Debug.Log("Vous avez le bon code, prenez la carte Random 1");
            }
            if (codeTextValue == RightCodes[3]) // CODE 0000 CODE RANDOM 2
            {
                codeRandom2.SetActive(true);
                Debug.Log("Vous avez le bon code, prenez la carte Random 2");
            }

        }
        else
        {
            this.gameObject.GetComponent<Timer>().Penality();
            wrongCode.SetActive(true);
            Debug.Log("Mauvais code, 1 min de pénalité");
            codeTextValue = "";
        }
        

    }

    public void CloseCodeWrongWindow()
    {
        wrongCode.SetActive(false);
    }
    public void CloseRandom1CodeWindow()
    {
        codeRandom1.SetActive(false);
    }
    public void CloseRandom2CodeWindow()
    {
        codeRandom2.SetActive(false);
    }
    public void CloseCarnivalCodeWindow()
    {
        codeCarnival.SetActive(false);
    }
    public void CloseHauntedHouseCodeWindow()
    {
        codeHautedHouse.SetActive(false);
    }
    
}
