using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticket : MonoBehaviour
{
    public GameObject bouleGO;
    public GameObject ticketText;
    public float DisplayTime = 2.5f;
    void OnMouseDown() 
    {
        Debug.Log("Touché");
        StartCoroutine(TookTicket());
    }

    public IEnumerator TookTicket()
    {
        ticketText.SetActive(true);
        yield return new WaitForSeconds(DisplayTime);
        ticketText.SetActive(false);
        bouleGO.SetActive(false);
    }
}
