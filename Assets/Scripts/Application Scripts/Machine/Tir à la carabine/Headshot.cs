using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headshot : MonoBehaviour
{
    public GameObject canvasMain;
    public GameObject canvasMachine;

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
            StartCoroutine(spawnCanvasMain());
        }
    public void MachineSucces()
    {
        succesText.SetActive(true);
        foreach(var deleted in toDelete)
        {
            deleted.SetActive(false);
        }
    }
    public IEnumerator spawnCanvasMain()
    {
        succesText.SetActive(true);
        yield return new WaitForSeconds(5f);
        succesText.SetActive(false);
        canvasMain.SetActive(true);
    }

}
