using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headshot : MonoBehaviour
{
    public GameObject canvasMain;
    public static GameObject canvasMachine;
    public static GameObject canvasCarabine;

    public GameObject forainHead;
    public GameObject forainBody;
    public GameObject succesText;
    public List<GameObject> toDelete = new List<GameObject>();
    public GameObject bg;
    public GameObject carabine;
    public GameObject backbutton;

    SoundManager soundManager;
    Machine machine;
    // Start is called before the first frame update

    void Start() 
    {
        machine = GameObject.Find("AppliManager").GetComponent<Machine>();
        soundManager = GameObject.Find("AppliManager").GetComponent<SoundManager>();
    }
    public void OnMouseDown() 
    {
        forainBody.GetComponent<SpriteRenderer>().sprite = null;
        forainHead.GetComponent<SpriteRenderer>().sprite = null;
        MachineSucces();
        StartCoroutine(spawnCanvasMain());
    }
    public void MachineSucces()
    {
        soundManager.ForainHit();
        succesText.SetActive(true);
        foreach(var deleted in toDelete)
        {
            deleted.SetActive(false);
        }
        
    }
    public IEnumerator spawnCanvasMain()
    {
        soundManager.carabineIsOpen = false;
        succesText.SetActive(true);
        yield return new WaitForSeconds(3f);
        bg.SetActive(false);
        canvasMain.SetActive(true);
        carabine.SetActive(false);
        canvasCarabine.SetActive(false);
    }

}
