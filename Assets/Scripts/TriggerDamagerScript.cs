using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDamagerScript : MonoBehaviour
{
    public TargetTag targetTag;
    public int damage;
    public GameObject PickUpObject;
    public bool HealingObject;

    public void Start()
    {
        if (HealingObject == true)
        {
            damage = -damage;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == targetTag.ToString())
        {
            HealthScript script = other.gameObject.GetComponent<HealthScript>();
            if (script != null)
            {
                other.gameObject.SendMessage("TakeDamage", damage);

                if (PickUpObject != null)
                {
                    PickUpObject.SetActive(false);
                }
                
            }
        }
        
    }
}
