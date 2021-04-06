using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ARTimer : MonoBehaviour
{
    public UnityEvent OnTimerReachZero;

    bool TimerRunning = true;

    // Update is called once per frame
    void Update()
    {
        if (TimerRunning)
        {
            if (Timer.timeRemaining > 0)
            {
                Timer.timeRemaining -= Time.deltaTime;
            }
            if (Timer.timeRemaining <= 0)
            {
                OnTimerReachZero.Invoke();
                TimerRunning = false;
            }
        }
    }
}
