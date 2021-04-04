using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemoveButton : MonoBehaviour
{
    Button thisButton;

    public void Start()
    {
        thisButton = this.gameObject.GetComponent<Button>();
    }
    public void RemoveThis()
    {
        thisButton.interactable = false;
    }
}
