using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckCaught : MonoBehaviour
{
    public Transform Hook;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Hook.position;
    }
}
