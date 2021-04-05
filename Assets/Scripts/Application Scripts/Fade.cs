using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    private bool fadeOut, fadeIn;
    public float fadeSpeed;

    public void FadeOut()
    {
        StartCoroutine(FadeOutObject());
    }
    public void FadeIn()
    {
        StartCoroutine(FadeInObject());
    }
    public IEnumerator FadeOutObject()
    {
        while(this.GetComponent<Renderer>().material.color.a > 0)
        {
            Color objectColor = this.GetComponent<Renderer>().material.color;
            float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            this.GetComponent<Renderer>().material.color = objectColor;
            yield return null;
        }
    }
    public IEnumerator FadeInObject()
    {
        while(this.GetComponent<Renderer>().material.color.a <1)
        {
            Color objectColor = this.GetComponent<Renderer>().material.color;
            float fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            this.GetComponent<Renderer>().material.color = objectColor;
            yield return null;
        }
    }
        
}
