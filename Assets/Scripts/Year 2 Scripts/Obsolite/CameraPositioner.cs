using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositioner : MonoBehaviour
{
    public GameObject Camera;
    public Vector3 TargetPosition = new Vector3(0f,1f,-10f);
    public Vector3 OriginalPosition = new Vector3(0f, 1f, -10f);
    private void OnTriggerEnter(Collider other)
    {
        Camera.SendMessage("ImportPos" ,TargetPosition);
        Camera.SendMessage("Move", true);
    }
    private void OnTriggerExit(Collider other)
    {
        Camera.SendMessage("ImportPos", OriginalPosition);
        Camera.SendMessage("Move", false);
    }
}
