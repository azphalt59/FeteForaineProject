using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WrongTarrget : MonoBehaviour
{
    Timer timer;
    public GameObject penalityGameObject;
    public float timeToDisplay = 2f;

    public void Start() 
    {
        timer = GameObject.Find("AppliManager").GetComponent<Timer>();
    }
    void OnMouseDown() 
    {
        addPenality();
        StartCoroutine(MessagePenalityTime());
        this.gameObject.GetComponent<SpriteRenderer>().sprite = null;
        
    }
    public void addPenality()
    {
        timer.LitttleLittlePenality();
    }
    
    public IEnumerator MessagePenalityTime()
    {
        penalityGameObject.SetActive(true);
        yield return new WaitForSeconds(timeToDisplay);
        penalityGameObject.SetActive(false);
        
    }
}
