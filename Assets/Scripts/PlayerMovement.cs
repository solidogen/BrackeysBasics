﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
/* 
    TODO store enum [left, right, none] in update method from keys.
    then in fixedUpdate check enum value and apply force if needed.
 */

    private Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
