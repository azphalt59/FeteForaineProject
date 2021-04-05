using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyShot : MonoBehaviour
{
    public GameObject angryText;
    public float timeToDisplay = 2f;
    SoundManager soundManager;

    void Start() 
    {
        soundManager = GameObject.Find("AppliManager").GetComponent<SoundManager>();
    }
    public void OnMouseDown() 
    {
        StartCoroutine(MessagePenalityTime());
    }

    public IEnumerator MessagePenalityTime()
    {
        angryText.SetActive(true);
        soundManager.ForainHit();
        yield return new WaitForSeconds(timeToDisplay);
        angryText.SetActive(false);  
    }
}
