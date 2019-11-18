using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOverTime : MonoBehaviour
{
    public float Speed = 2f;
    public bool X;
    public bool Y;
    public bool Z;
    public float XAngle = 0;
    public float yAngle = 0;
    public float zAngle = 0;

    void Start()
    {
        
    }
    void Update()
    {
        if (X == true)
        {
            XAngle = XAngle + Speed;
        }
        if (Y == true)
        {
           yAngle = yAngle + Speed;
        }
        if (Z == true)
        {
            zAngle = zAngle + Speed;
        }

        transform.eulerAngles = new Vector3(XAngle, yAngle, zAngle);
    }
}
