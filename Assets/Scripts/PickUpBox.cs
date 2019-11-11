using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBox : MonoBehaviour
{
    public Transform Target;
    public Collider PickupColl;

    public Transform HoldPos;
    public TargetTag targetTag;


    private void Update()
    {
        if (Target != null)
        {
            Target.position = HoldPos.position;

            if (Input.GetKey("e"))
            {
                Target.SetParent(transform);
                
            }
            else
            {
                Target.gameObject.SendMessage("ParentSwitch", true);
                Target.SetParent(null);
                Target = null;
                PickupColl.enabled = true;
            }
           
        }
    

        

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == targetTag.ToString())
        {
            if (Input.GetKey("e"))
            {

                Target = other.transform;
                Target.gameObject.SendMessage("ParentSwitch", false);
                PickupColl.enabled = false;



            }

        }
    }
}
