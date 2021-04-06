using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    SoundManager soundManager;
    GoToScene goToScene;

    public List<string> machines = new List<string>();
    [Header("Machines")]
    public GameObject TirCarabine;
    public GameObject LaBoule;
    public GameObject Cryptex;
    public GameObject ToucheCoule;

    public static bool CarabineDone = false;
    public static bool ToucheCouleDone = false;
    public static bool PlombDone = false;
    public static bool CryptexDone= false;

    void Start() 
    {
        soundManager = this.gameObject.GetComponent<SoundManager>();
        goToScene = this.gameObject.GetComponent<GoToScene>();
    }
    void Update()
    {
        DisplayCode();
        if (machineTextValue.Length > 3)
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
                soundManager.carabineIsOpen = true;
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
            if(machineTextValue == machines[5]) //100
                {
                    goToScene.LoadScene();
                }
            if(machineTextValue == machines[6]) //23
                {
                    goToScene.LoadScene();
                }
            if(machineTextValue == machines[7]) //32
                {
                    goToScene.LoadScene();
                }
        }
        else
                {
                wrongMachine.SetActive(true);
                Debug.Log("Machine inconnue");
                machineTextValue = "";
                }
    }
    public void CloseCodeWrongWindow()
    {
        wrongMachine.SetActive(false);
    }
}
    
            
            
            
        
    


