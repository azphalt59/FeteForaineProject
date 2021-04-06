using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ARTimerDisplay : MonoBehaviour
{
    private Text text;

    private void Start() {
        text = GetComponent<Text>();
    }

    private void Update() {

        
        float minutes = Mathf.FloorToInt(Timer.timeRemaining / 60);
        float seconds = Mathf.FloorToInt(Timer.timeRemaining % 60);

        text.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
