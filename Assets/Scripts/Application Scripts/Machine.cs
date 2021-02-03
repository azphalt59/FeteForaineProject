using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Machine : MonoBehaviour
{
    public Text machineText;
    string machineTextValue = "";
    public GameObject canvasMachine;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayCode();
        if (machineTextValue.Length > 2)
        {
            machineTextValue = "";
        }
    }

    public void ActiveCanvasMachine()
    {
        canvasMachine.SetActive(true);
    }
    public void CloseCanvasMachine()
    {
        canvasMachine.SetActive(false);
    }
    public void DisplayCode()
    {
        machineText.text = machineTextValue;
    }
    public void AddNumber(string number)
    {
        machineTextValue += number;
    }
    public void ResetNumber()
    {
        machineTextValue = "";
    }
    public void ConfirmCode()
    {
        if(machineTextValue == "10")
        {
            Debug.Log("Lance la machine de la carte 10");
        }
        else
        {
            Debug.Log("Machine inconnue");
            machineTextValue = "";
        }
    }
}
