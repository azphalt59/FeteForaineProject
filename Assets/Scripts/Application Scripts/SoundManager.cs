using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource buttonSound;
    public AudioSource clownLaugh;
    public AudioSource voltageDrop;
    public AudioSource carabineShot;
    public AudioSource forainHit;
    public AudioSource electricity;
    public bool carabineIsOpen = false;

    public void Electricity()
    {
        electricity.Play();
    }
    public void ForainHit()
    {
        forainHit.Play();
    }
    public void ButtonSound()
    {
        buttonSound.Play();
    }
    public void ClownLaugh()
    {
        clownLaugh.Play();
    }
    public void VolageDrop()
    {
        voltageDrop.Play();
    }
    public void CarabineShot()
    {
        carabineShot.Play();
    }
    void Update() 
    {
        if(Input.GetMouseButtonDown(0) == true && carabineIsOpen == true) 
        {
            CarabineShot();
        }
    }
}
