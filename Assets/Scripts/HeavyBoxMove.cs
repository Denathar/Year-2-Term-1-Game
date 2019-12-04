using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyBoxMove : MonoBehaviour
{
    public GameObject Player;
    
    public Rigidbody PlayerRB;
    public Collider PickupColl;
    public TargetTag targetTag;


    public Transform Target;
    public Rigidbody TargetRB;

    private void Update()
    {
        if (Target != null)
        {
            

            if (Input.GetKey("e"))
            {
                

                TargetRB.velocity = PlayerRB.velocity;
                
            }
            else
            {
                
                Target = null;
                PickupColl.enabled = true;
                TargetRB.isKinematic = true;
                Player.SendMessage("JumpSwitch", true);
                Player.SendMessage("turningSwitch", true);
                TargetRB = null;
            }

        }




    }



    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == targetTag.ToString())
        {
            if (Input.GetKey("e"))
            {
                Player.SendMessage("SpeedChange", 1);
                Player.SendMessage("JumpSwitch", false);
                Player.SendMessage("turningSwitch", false);

                Target = other.transform;
                TargetRB = Target.GetComponent<Rigidbody>();

                PickupColl.enabled = false;

                TargetRB.isKinematic = false;

            }

        }
    }

}
