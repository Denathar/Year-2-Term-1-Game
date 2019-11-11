using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovmentNew : MonoBehaviour
{
    [SerializeField]
    private Rigidbody PlayerBody;

    public float Speed;
    public float JumpForce;
 

    public bool JumpOn = true;
    public bool Turning = true;

    public bool Zmove = false;
    public float MovePosition = 0;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    private bool Is0 = true;


    // Start is called before the first frame update
    void Start()
    {
        PlayerBody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        PlayerBody.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * Speed, PlayerBody.velocity.y, 0);
        if (Input.GetButton("Horizontal"))
        {
            if (Speed < 6f)
            {
                Speed += 0.1f;
            }
        }
        else
        {
            Speed = 2;
        }
        if (PlayerBody.velocity.x > -0.5f && PlayerBody.velocity.x < 0.5f)
        {
            PlayerBody.velocity = new Vector3(0f, PlayerBody.velocity.y, 0f);
            PlayerBody.angularVelocity = new Vector3(0f, PlayerBody.velocity.y, 0f);
        }
        if (JumpOn == true)
        {
            if (Input.GetButtonDown("Jump"))
            {
                PlayerBody.AddForce(0f, JumpForce, 0f);
            }
        }
        if (Input.GetButtonUp("Jump"))
        {
            PlayerBody.velocity -= new Vector3(0.0f, PlayerBody.velocity.y, 0.0f);
        }
        if (Turning == true)
        {
            if (PlayerBody.velocity.x < -1)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
            }
            if (PlayerBody.velocity.x > 1)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
        }

        Vector3 targetPosition = new Vector3(transform.position.x, transform.position.y, MovePosition);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        if (Zmove == true)
        {
            if (Input.GetKeyDown("w"))
            {
                

                if (Is0 == true)
                {
                    if (MovePosition == 0f)
                    {
                        MovePosition = -2f;
                        
                    }
                }
                if (Is0 == false)
                {
                    if (MovePosition == -2f)
                    {
                        MovePosition = 0f;
                        
                    }
                }

                Is0 = !Is0;

            }

        }
        

    }

    void ZmoveSwitch(bool Switch)
    {
        Zmove = Switch;
    }
    void JumpSwitch(bool SwitchJ)
    {
        JumpOn = SwitchJ;

    }

}
