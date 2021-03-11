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
    private Transform CentrePiscine;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = GetPosition((Time.time + StartOffset) * RotationTime * 360);
    }

    Vector3 GetPosition(float Time){
        Vector3 pos = new Vector3(0,CentrePiscine.position.y,DistanceFromCenter);
        
        float distanceNoise = Mathf.PerlinNoise(Time * DistanceNoiseScale,0);
        distanceNoise = distanceNoise - 0.5f;
        distanceNoise = distanceNoise * DistanceNoiseStrength;
        pos.z += distanceNoise;

        Vector3 finalpos = RotatePointAroundPivot(pos, CentrePiscine.position, new Vector3(0,Time,0));

        return finalpos;
    }

    public Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles) {
    return Quaternion.Euler(angles) * (point - pivot) + pivot;
  }
}
