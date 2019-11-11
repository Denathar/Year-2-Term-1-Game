using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTriggerAnim : MonoBehaviour
{
   
    public Animator animator;
    bool isOpen;
    
    

    private void OnTriggerEnter(Collider other)
    {
        animator.enabled = true;
    }



}
