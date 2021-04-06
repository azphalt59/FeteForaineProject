using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temps : MonoBehaviour
{
    public static float tempsEnlever;
    // Start is called before the first frame update
    void Start()
    {
        tempsEnlever = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tempsEnlever += Time.deltaTime;
    }
}
