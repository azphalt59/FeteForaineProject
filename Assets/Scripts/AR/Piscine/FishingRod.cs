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

    private bool IsInArea = false;

    public RodState CurrentRodState = RodState.idle;
    private DuckStateManager HookedDuck;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsInArea == false & HookedDuck != null){
            UnHookDuck();
        }
    }

    private void UnHookDuck(){
        HookedDuck.GetComponent<DuckIndex>().UnHook();
        HookedDuck = null;
    }

    public void TryHook(DuckStateManager manager){
        if (manager.CurrentCanardState == DuckStateManager.CanardStates.Swimming){
            manager.Caught(Hook);
            CurrentRodState = RodState.DuckCaught;
            HookedDuck = manager;
        }
    }

    private void OnTriggerEnter(Collider other) {
        DuckStateManager manager = other.GetComponent<DuckStateManager>();
        if (manager != null && HookedDuck == null){
            TryHook(manager);
        }
        if (other.tag == "PiscineArea"){
            IsInArea = true;
            Debug.Log("Entered Piscine");
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "PiscineArea"){
            IsInArea = false;
            Debug.Log("Left Piscine");
        }
    }
}
