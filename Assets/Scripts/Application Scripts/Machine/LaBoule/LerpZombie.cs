using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpZombie : MonoBehaviour
{
    [SerializeField] [Range(0f, 4f)] float lerpTime;
    [SerializeField] Vector3[] myPositions;
    int posIndex = 0;
    int lenght;
    float t = 0f;
    // Start is called before the first frame update
    void Start()
    {
        lenght = myPositions.Length;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp (transform.position, myPositions [posIndex], lerpTime * Time.deltaTime);
        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
        if(t>.9f)
        {
            t = 0f;
            posIndex ++;
            posIndex = (posIndex >= lenght) ? 0 : posIndex;
        }
    }
}
