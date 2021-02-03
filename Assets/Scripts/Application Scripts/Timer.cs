using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 3600f;
    public bool timerIsRunning = false;
    public Text timerText;
    public float penalityTime;
    public List<Button> buttons = new List<Button>();

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 0;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    private void Start()
    {
        timerIsRunning = false;
        DisplayTime(timeRemaining);
    }

    public void PauseAndResume()
    {
        if(timerIsRunning == true)
        {
            Time.timeScale = 0;
            timerIsRunning = false;
        } else
        {
            Time.timeScale = 1;
            timerIsRunning = true;
        }
    }
    public void Penality()
    {
        timeRemaining -= penalityTime;
    }
    
    void Update()
    {
        if(timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("YA PLUS DE TEMPS");
                timeRemaining = 0;
                timerIsRunning = false;
            }
            foreach (var Button in buttons)
            {
                Button.interactable = true;
            }
        }
        else
        {
            foreach(var Button in buttons)
            {
                Button.interactable = false;
            }
        }
        
    }
}
