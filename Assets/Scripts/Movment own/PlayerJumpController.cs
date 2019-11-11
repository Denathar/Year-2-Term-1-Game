using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpController : MonoBehaviour
{


    void OnTriggerStay(Collider other)
    {
        gameObject.SendMessageUpwards("JumpSwitch", true);
    }
    private void OnTriggerExit(Collider other)
    {
        gameObject.SendMessageUpwards("JumpSwitch", false);
    }


}
