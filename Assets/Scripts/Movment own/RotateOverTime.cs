using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOverTime : MonoBehaviour
{
    public float Speed = 2f;
    public float StartAngle = 0;

    void Start()
    {
        
    }
    void Update()
    {
        StartAngle = StartAngle + Speed;

        transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y, StartAngle);
    }
}
