using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiscineManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> Letters = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject letter in Letters){
            letter.SetActive(false);
        }
    }

    public void ShowLetter(int index){
        Letters[index].SetActive(true);
    }
}
