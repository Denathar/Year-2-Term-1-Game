using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDrop : MonoBehaviour
{
    public GameObject PickUpCollider;
    public Collider hit;
    public TargetTag targetTag;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == targetTag.ToString())
        {

        }
        else
        {
            hit = other;
            PickUpCollider.SendMessage("Drop");
        }
        
    }

  


}
