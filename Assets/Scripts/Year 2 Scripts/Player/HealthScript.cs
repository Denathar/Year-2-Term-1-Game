using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    [SerializeField]
    protected int health = 100;
    [SerializeField]
    protected int currentHealth = 100;


    public virtual void Update()
    {
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        
    }

    public virtual void Die()
    {
        gameObject.SetActive(false);
    }
}
