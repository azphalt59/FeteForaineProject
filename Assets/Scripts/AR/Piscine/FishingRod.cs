using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingRod : MonoBehaviour
{
    public Transform Hook;

    public enum RodState{
        idle,
        DuckCaught
    }

    public RodState CurrentRodState = RodState.idle;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TryHook(DuckStateManager manager){
        if (manager.CurrentCanardState == DuckStateManager.CanardStates.Swimming){
            manager.Caught(Hook);
            CurrentRodState = RodState.DuckCaught;
        }
    }

    private void OnTriggerEnter(Collider other) {
        DuckStateManager manager = other.GetComponent<DuckStateManager>();
        if (manager != null){
            TryHook(manager);
        }
    }
}
