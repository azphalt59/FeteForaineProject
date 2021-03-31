using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Machine : MonoBehaviour
{
    public Text machineText;
    string machineTextValue = "";
    public GameObject canvasMachine;
    public GameObject wrongMachine;
    public GameObject canvasMain;
    public GameObject canvasCryptex;
    public GameObject canvasToucheCoule;
    public GameObject canvasPlomb;
    public GameObject canvasCarabine;

    public List<string> machines = new List<string>();
    [Header("Machines")]
    public GameObject TirCarabine;
    public GameObject LaBoule;
    public GameObject Cryptex;
    public GameObject ToucheCoule;

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
        if (machines.Contains(machineTextValue))
        {
            if(machineTextValue == machines[0]) //77
                {
                canvasCarabine.SetActive(true);
                TirCarabine.SetActive(true);
                canvasMain.SetActive(false);
                canvasMachine.SetActive(false);
                Debug.Log("MachineCarabine");
                }
            if(machineTextValue == machines[2]) //79
                {
                Cryptex.SetActive(true);
                Debug.Log("MachineCryptex");
                canvasMain.SetActive(false);
                canvasMachine.SetActive(false);
                canvasCryptex.SetActive(true);
                }
            if(machineTextValue == machines[3]) //87
                {
                ToucheCoule.SetActive(true);
                canvasToucheCoule.SetActive(true);
                canvasMain.SetActive(false);
                canvasMachine.SetActive(false);
                Debug.Log("MachineToucheCoule");
                }
            if(machineTextValue == machines[4]) //87
                {
                canvasPlomb.SetActive(true);
                canvasMain.SetActive(false);
                canvasMachine.SetActive(false);
                Debug.Log("MachinePlomb");
                }
            else
                {
                Debug.Log("Machine inconnue");
                machineTextValue = "";
                }
        }
    }
}
    
            
            
            
        
    


