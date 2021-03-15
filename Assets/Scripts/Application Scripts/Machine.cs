using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Machine : MonoBehaviour
{
    public Text machineText;
    string machineTextValue = "";
    public GameObject canvasMachine;

    public List<string> machines = new List<string>();
    [Header("Machines")]
    public GameObject TirCarabine;
    public GameObject LaBoule;
    public GameObject Cryptex;
    public GameObject ToucheCoule;

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
        if (machines.Contains(machineTextValue))
        {
            if(machineTextValue == machines[0]) //01
            {
                TirCarabine.SetActive(true);
                Debug.Log("MachineCarabine");
            }
            if(machineTextValue == machines[1]) //10
            {
                LaBoule.SetActive(true);
                Debug.Log("MachineCarabine");
            }
            if(machineTextValue == machines[2]) //30
            {
                Cryptex.SetActive(true);
                Debug.Log("MachineCarabine");
            }
            if(machineTextValue == machines[3]) //55
            {
                ToucheCoule.SetActive(true);
                Debug.Log("MachineCarabine");
            }
        }
        else
        {
            Debug.Log("Machine inconnue");
            machineTextValue = "";
        }
    }
}
