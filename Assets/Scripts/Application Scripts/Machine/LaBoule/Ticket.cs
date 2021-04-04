using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticket : MonoBehaviour
{
    public GameObject bouleGO;
    public GameObject ticketText;
    public GameObject canvasMain;

    public GameObject zombie;
    public float DisplayTime = 5f;
    void OnMouseDown() 
    {
        Debug.Log("Touché");
        zombie.GetComponent<SpriteRenderer>().sprite = null;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = null;
        StartCoroutine(TookTicket());
    }

    public IEnumerator TookTicket()
    {
        ticketText.SetActive(true);
        yield return new WaitForSeconds(DisplayTime);
        ticketText.SetActive(false);
        bouleGO.SetActive(false);
        canvasMain.SetActive(true);
    }
}
