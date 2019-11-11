using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightEvent : MonoBehaviour
{
    public Light[] lights;
    int position = 0;

    public float timer = 0.3f;
	
    private void OnTriggerEnter(Collider other)
    {
        InvokeRepeating("TurnOffLight", timer, timer);

        //Invoke("TurnOffLight", timer); one time
    }

    void TurnOffLight()
    {
        if (lights.Length > position)
        {
            if (lights[position] != null)
            {
                lights[position].enabled = false;
                position++;
            }
        }

        if(position > lights.Length)
        {
            CancelInvoke();
        }
    
    }
}
