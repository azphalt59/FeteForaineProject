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
    float littlePenalityTime = 30f;
    float littlelittlepenalityTime = 20f;
    public List<Button> buttons = new List<Button>();
    
    public GameObject littlePenalityText;

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
    public void LittlePenality()
    {
        StartCoroutine(DisplayLittlePenality());
        timeRemaining -= littlePenalityTime;
    }
    public void LitttleLittlePenality()
    {
        timeRemaining -= littlelittlepenalityTime;
    }
    
    public IEnumerator DisplayLittlePenality()
    {
        littlePenalityText.SetActive(true);
        yield return new WaitForSeconds(3f);
        littlePenalityText.SetActive(false);
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
