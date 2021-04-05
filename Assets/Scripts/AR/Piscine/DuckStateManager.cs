using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckStateManager : MonoBehaviour
{
    [System.Serializable]
    public enum CanardStates{
        Swimming,
        Caught
    }
    public CanardStates CurrentCanardState { get; private set; } = CanardStates.Swimming;

    private DuckMovement duckMovement;
    private DuckCaught duckCaught;

    private void Awake() {
        duckMovement = GetComponent<DuckMovement>();
        duckCaught = GetComponent<DuckCaught>();
        duckCaught.enabled = false;
        duckMovement.enabled = true;
    }

    public void Caught(Transform Hook){
        CurrentCanardState = CanardStates.Caught;
        duckCaught.Hook = Hook;
        duckMovement.enabled = false;
        duckCaught.enabled = true;
    }
}