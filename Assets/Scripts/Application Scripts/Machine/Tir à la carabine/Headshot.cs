using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headshot : MonoBehaviour
{
    public GameObject forainHead;
    public GameObject forainBody;
    public GameObject succesText;
    public List<GameObject> toDelete = new List<GameObject>();
    // Start is called before the first frame update
    public void OnMouseDown() 
        {
            forainBody.GetComponent<SpriteRenderer>().sprite = null;
            forainHead.GetComponent<SpriteRenderer>().sprite = null;
            MachineSucces();
        }
    public void MachineSucces()
    {
        succesText.SetActive(true);
        foreach(var deleted in toDelete)
        {
            deleted.SetActive(false);
        }

    }

}
