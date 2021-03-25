using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMovement : MonoBehaviour
{
    [SerializeField]
    private float StartOffset;
    [SerializeField]
    private float RotationTime;
    [SerializeField]
    private float DistanceFromCenter;
    [SerializeField]
    private float DistanceNoiseStrength;
    [SerializeField]
    private float DistanceNoiseScale;
    [SerializeField]
    private float BobblingSpeed = 2;
    [SerializeField]
    private float BobbleAngle = 15;
    [SerializeField]
    private float FloatFactor = 0.0625f / 2;

    [SerializeField]
    private Transform CentrePiscine;
    [SerializeField]
    private Transform Model;

    [System.Serializable]
    private enum CanardStates{
        Swimming,
        Caught
    }

    private CanardStates CurrentCanardState = CanardStates.Swimming;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = GetSwimPosition((Time.time + StartOffset) * RotationTime * 360);
        Model.transform.localEulerAngles = GetSwimRotation((Time.time + StartOffset) * BobblingSpeed);
    }

    Vector3 GetSwimPosition(float Time){
        Vector3 pos = new Vector3(0,CentrePiscine.localPosition.y,DistanceFromCenter);
        
        float distanceNoise = Mathf.PerlinNoise(Time * DistanceNoiseScale,0);
        distanceNoise = distanceNoise - 0.5f;
        distanceNoise = distanceNoise * DistanceNoiseStrength;
        pos.z += distanceNoise;

        Vector3 finalpos = RotatePointAroundPivot(pos, CentrePiscine.localPosition, new Vector3(0,Time,0));
        finalpos.y += (Mathf.Sin((Time / 360) * 16) * FloatFactor) / 2;

        return finalpos;
    }

    Vector3 GetSwimRotation(float Time){
        Vector3 rotation = Vector3.zero;
        rotation.x = Mathf.Cos(Time);
        rotation.z = Mathf.Sin(Time);
        rotation = rotation * BobbleAngle;
        return rotation;
    }

    public Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles) {
    return Quaternion.Euler(angles) * (point - pivot) + pivot;
  }
}
