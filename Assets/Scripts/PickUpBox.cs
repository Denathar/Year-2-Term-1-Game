﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBox : MonoBehaviour
{
    public Rigidbody PlayerRB;
    public Transform Target;
    public Collider PickupColl;

    public Transform HoldPos;
    public TargetTag targetTag;
    public TargetTag targetTag2;


    public bool drop = false;

    private void Update()
    {
        if (Target != null)
        {
            Target.position = HoldPos.position;
            if (drop == false)
            {
                if (Input.GetKey("e"))
                {
                    Target.SetParent(transform);


                }
                else
                {
                    Target.gameObject.SendMessage("ParentSwitch", true);
                    PickupColl.enabled = true;

                    Target = null;
                    PlayerRB.mass = 1;
                }
            }
            
           
        }

        
        

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == targetTag.ToString() || other.gameObject.tag == targetTag2.ToString())
        {
            if (drop == false)
            {
                if (Input.GetKey("e"))
                {
                    PlayerRB.mass = 1.25f;

                    Target = other.transform;

                    Target.gameObject.SendMessage("ParentSwitch", false);

                    PickupColl.enabled = false;

                }
            }
            

        }
    }
    void Drop()
    {
        if (Target != null)
        {
            Target.gameObject.SendMessage("ParentSwitch", true);
            Target = null;
            PickupColl.enabled = true;

            PlayerRB.mass = 1;
            
            drop = true;
        }    
    }
    void DropSwitch(bool DSwitch)
    {
        drop = DSwitch;
    }
}