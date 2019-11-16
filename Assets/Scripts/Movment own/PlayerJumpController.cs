using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpController : MonoBehaviour
{
    public GameObject PickUpCollider;

    void OnTriggerStay(Collider other)
    {
        gameObject.SendMessageUpwards("JumpSwitch", true);
        PickUpCollider.SendMessage("DropSwitch", false);
    }
    private void OnTriggerExit(Collider other)
    {
        gameObject.SendMessageUpwards("JumpSwitch", false);
    }


}
