using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    [SerializeField]
    private string Scene;
    
    public void LoadScene(){
        SceneManager.LoadScene(Scene);
    }
}
