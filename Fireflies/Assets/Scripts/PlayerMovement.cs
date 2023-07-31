using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D charM;
    float horiMove = 0f;
    float charSpeed = 30f;
    bool charJump = false;
    //took out start as this is movement
    // Update is called once per frame

    void Update()
    {
        //gonna add slow debuff here eventually
        horiMove = Input.GetAxisRaw("Horizontal") * charSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            charJump = true;
        }
       
    }
    void FixedUpdate()//called fixed amt time per second
    {
        charM.Move(horiMove * Time.fixedDeltaTime,false, charJump);
        charJump = false;
    }
}
