using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthScript : HealthScript
{
    public Slider HealthBar;
    public GameObject LifeIcon;
    public GameObject LifeIcon2;
    public GameObject LifeIcon3;
    public GameObject LifeIcon4;
    public GameObject LifeIcon5;

    public override void Update()
    {
        base.Update();
        HealthBar.value = (float)currentHealth / (float)health;
        if (currentHealth == 100)
        {
            LifeIcon.SetActive(true);
            LifeIcon2.SetActive(true);
            LifeIcon3.SetActive(true);
            LifeIcon4.SetActive(true);
            LifeIcon5.SetActive(true);
        }
        if (currentHealth == 80)
        {
            LifeIcon.SetActive(true);
            LifeIcon2.SetActive(true);
            LifeIcon3.SetActive(true);
            LifeIcon4.SetActive(true);
            LifeIcon5.SetActive(false);
        }
        if (currentHealth == 60)
        {
            LifeIcon.SetActive(true);
            LifeIcon2.SetActive(true);
            LifeIcon3.SetActive(true);
            LifeIcon4.SetActive(false);
            LifeIcon5.SetActive(false);
        }
        if (currentHealth == 40)
        {
            LifeIcon.SetActive(true);
            LifeIcon2.SetActive(true);
            LifeIcon3.SetActive(false);
            LifeIcon4.SetActive(false);
            LifeIcon5.SetActive(false);
        }
        if (currentHealth == 20)
        {
            LifeIcon.SetActive(true);
            LifeIcon2.SetActive(false);
            LifeIcon3.SetActive(false);
            LifeIcon4.SetActive(false);
            LifeIcon5.SetActive(false);
        }
        if (currentHealth == 0)
        {
            LifeIcon.SetActive(false);
            LifeIcon2.SetActive(false);
            LifeIcon3.SetActive(false);
            LifeIcon4.SetActive(false);
            LifeIcon5.SetActive(false);
        }
    }
}
