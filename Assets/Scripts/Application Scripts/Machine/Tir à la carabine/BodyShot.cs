using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyShot : MonoBehaviour
{
    public GameObject angryText;
    public float timeToDisplay = 1f;
    // Start is called before the first frame update
    public void OnMouseDown() 
    {
        StartCoroutine(MessagePenalityTime());
    }

    public IEnumerator MessagePenalityTime()
    {
        angryText.SetActive(true);
        yield return new WaitForSeconds(timeToDisplay);
        angryText.SetActive(false);  
    }
}
