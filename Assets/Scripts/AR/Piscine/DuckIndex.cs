using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckIndex : MonoBehaviour
{
    public int index;
    [SerializeField]
    private PiscineManager manager;

    public void UnHook(){
        manager.ShowLetter(index);
        gameObject.SetActive(false);
    }
}
