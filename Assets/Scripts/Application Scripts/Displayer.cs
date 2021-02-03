using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Displayer : MonoBehaviour
{
    Code code;
    public Text displayerText;
    // Start is called before the first frame update
    void Start()
    {
        code = GameObject.Find("AppliManager").GetComponent<Code>();

    }

    // Update is called once per frame
    void Update()
    {
        displayerText.text = code.codeText.text;

    }
}
