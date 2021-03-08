using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class CraftCard : MonoBehaviour
{
    public string ID;
    [SerializeField]
    private GameObject model;

    public static List<CraftCard> AllCards = new List<CraftCard>();

    private void OnEnable() {
        AllCards.Add(this);
    }

    private void OnDisable() {
        AllCards.Remove(this);
    }

    public void ActivateModel(bool active = true){
        model.SetActive(active);
    }
}
