using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Indice
{
    
    public int index;
    public string st;
    public string st2;
    public string st3;
    public int count;

    public Indice(Indice tips)
    {
        st = tips.st;
        st2 = tips.st2;
        st3 = tips.st3;
        index = tips.index;
        count = tips.count;
    }
}
